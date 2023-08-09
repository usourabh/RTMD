$(document).ready(function () {
    ShowDeviceTransactionData();
    $('#DeviceInfo tbody').on('click', 'td.details-control', function () {
        var tr = $(this).closest('tr');
        var rownext = $(this).closest('tr').next('tr');
        // var row = $('#DeviceInfo').DataTable().row(tr);
        // alert(tr.html());
        //var routecode = tr.find('td:eq(5)').text();
        var ticketid = tr.attr('ticketid');
        if ((tr.hasClass('shown'))) {
            rownext.hide();
            tr.removeClass('shown');
        }
        else {
            // Open this row
            $.ajax({
                url: "/DeviceTransaction/TransactionById",
                type: "POST",
                dataType: "json",
                data: { imei: ticketid },
                success: function (data) {
                    var txtChildTable = '';
                    txtChildTable += '<tr>';
                    txtChildTable += '<td colspan="6">';
                    txtChildTable += formatVehicle(data);
                    txtChildTable += '</td>';
                    txtChildTable += '</tr>';
                    $(tr).after(txtChildTable);
                    tr.addClass('shown');
                }
            });
        }
    });
});

function formatVehicle(item) {
    var InnerGrid = '<div class="table-scrollable vehicletable" style="padding-left:10px;margin:10px;"><table class="table"><thead><tr><th>Sr. No.</th><th> IMEI Number </th><th> Temperature </th><th> Dated On </th></tr></thead><tbody>';
    if (item != null && item.length > 0) {
        $.each(item, function (i, info) {
            if (info.CurrentActionStatus == 2 || info.TotalMin > 15)
                InnerGrid += '<tr style="background-color:#FFCCCB">';
            else
                InnerGrid += '<tr>';

            InnerGrid += '<td>' + (i + 1) + '</td>' +
                '<td>' + info.Imei + '</td>' +
                '<td>' + info.Temp + '</td>' +
                '<td>' + info.DatedOn + '</td>' +
                '</tr>';

            var txtChildTable = '';
            txtChildTable += '<tr class="dvacctiondetail" style="display:none">';
            txtChildTable += '<td colspan="6">';
            txtChildTable += '</td>';
            txtChildTable += '</tr>';
            InnerGrid += txtChildTable;
        });

        InnerGrid += '</tbody></table></div>';
    }
    else {
        InnerGrid += '<tr><td colspan="6">No Item</td></tr></tbody></table></div>';
    }



    return InnerGrid;
}

function ShowDeviceTransactionData() {
    $.ajax({
        url: "/DeviceTransaction/ActiveAlarmDeviceTransaction",
        type: 'get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (strresult) {
            var result = JSON.parse(strresult);
            var object = '';
            $.each(result, function (index, item) {
                object += '<tr ticketid="' + item.IEMINumber + '">';
                object += '<td  class="details-control"></td>';
                object += '<td>' + item.RDName + '</td>';
                if (parseFloat(item.Temp) > 24 || parseFloat(item.Temp) < 18) {
                    object += '<td style="color:red;"class="blink" ><marquee direction ="up"width="100%" behavior="alternate" scrollamount="2" scrolldelay=".1">' + item.Temp + '</marquee></td>';
                }
                else {
                    object += '<td style="color:black;">' + item.Temp + '</td>';
                }
                object += '<td>' + item.Phone + '</td>';
                object += '<td>' + item.ContactPerson + '</td>';
                object += '<td>' + item.Branch + '</td>';
                object += '<td>' + item.RegionName + '</td>';
                object += '<td>' + item.ASMArea + '</td>';
                object += '<td>' + item.Soterritory + '</td>';
                object += '<td>' + item.IEMINumber + '</td>';
                object += '<td>' + item.DeviceType + '</td>';
                object += '<td>' + item.EmailId + '</td>';
                object += '<td>' + item.DatedOn + '</td>';
                object += '<td><button imei="' + item.IEMINumber + '" href="javascript:void(0);" title="Details" class="btn btn-primary" onclick="ShowModal(this);"><i class="fa fa-eye"></i></button></td>';
                object += '</tr>';
            })

            $('#DeviceInfo > tbody').html(object);

            $('#DeviceInfo').dataTable({
                dom: 'Bfrtip',
                buttons: [
                    'copy', 'csv', 'excel', 'pdf', 'print'
                ]
            });
        },
        error: function () {
            alert("data can't get");
        }
    });
};

function ShowModal(objthis) {
    ShowGraf(objthis);
    $('#SaleModalChart').modal('show');
}

function ShowGraf(objthis) {
    var imei = $(objthis).attr("imei");
    $.ajax({
        url: "/DeviceTransaction/GetChartData",
        type: 'POST',
        data: { imei: imei },
        success: function (jsdata) {
            var d1 = [];
            var d2 = [];
            var d3 = [];
            for (var i = 0; i < jsdata.length; i++) {
                var Item = jsdata[i];

                d1.push({ x: new Date(Item.yy, Item.mm, Item.dd), y: Item.Tmax });
                d2.push({ x: new Date(Item.yy, Item.mm, Item.dd), y: Item.Tavg });
                d3.push({ x: new Date(Item.yy, Item.mm, Item.dd), y: Item.TMin });
            }

            var options = {
                animationEnabled: true,
                theme: "light2",
                title: {
                    text: "LAST 7 DAYS MONITORING"
                },
                axisX: {
                },
                axisY: {
                    prefix: "℃ ",
                    labelFormatter: addSymbols
                },
                toolTip: {
                    shared: true
                },
                legend: {
                    cursor: "pointer",
                    itemclick: toggleDataSeries
                },
                data: [
                    {
                        type: "column",
                        name: "Maximum Temp",
                        showInLegend: true,
                        dataPoints: d1
                    },
                    {
                        type: "line",
                        name: "Average Temp",
                        showInLegend: true,
                        dataPoints: d2
                    },
                    {
                        type: "area",
                        name: "Low Temp",
                        markerBorderColor: "white",
                        markerBorderThickness: 2,
                        showInLegend: true,
                        dataPoints: d3
                    }]
            };

            $("#chartContainer").CanvasJSChart(options);

            function addSymbols(e) {
                var suffixes = ["", "K", "M", "B"];
                var order = Math.max(Math.floor(Math.log(e.value) / Math.log(1000)), 0);

                if (order > suffixes.length - 1)
                    order = suffixes.length - 1;

                var suffix = suffixes[order];
                return CanvasJS.formatNumber(e.value / Math.pow(1000, order)) + suffix;
            }

            function toggleDataSeries(e) {
                if (typeof (e.dataSeries.visible) === "undefined" || e.dataSeries.visible) {
                    e.dataSeries.visible = false;
                } else {
                    e.dataSeries.visible = true;
                }
                e.chart.render();
            }
        },
        error: function (xhr, status, error) {
            alert("Result: " + status + " " + error + " " + xhr.status + " " + xhr.statusText)
        }
    });

}













