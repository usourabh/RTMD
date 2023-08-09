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
                    txtChildTable += '<td colspan="4">';
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
                '<td>' + info.imei + '</td>' +
                '<td>' + info.temp + '</td>' +
                '<td>' + info.datedOn + '</td>' +
                '</tr>';

            var txtChildTable = '';

            txtChildTable += '<tr class="dvacctiondetail" style="display:none">';
            txtChildTable += '<td colspan="4">';
            txtChildTable += '</td>';
            txtChildTable += '</tr>';
            InnerGrid += txtChildTable;
        });

        InnerGrid += '</tbody></table></div>';
    }
    else {
        InnerGrid += '<tr><td colspan="4">No Item</td></tr></tbody></table></div>';
    }



    return InnerGrid;
}
function ShowDeviceTransactionData() {
    $.ajax({
        url: "/DeviceTransaction/Transaction",
        type: 'get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (strresult) {
            var result = JSON.parse(strresult);
            var object = '';
            $.each(result, function (index, item) {
                debugger;
                object += '<tr ticketid="' + item.IEMINumber + '">';
                object += '<td  class="details-control"></td>';
                object += '<td>' + item.IEMINumber + '</td>';
                if (parseFloat(item.Temp) > 22 || parseFloat(item.Temp) < 18) {
                    object += '<td style="color:red;"class="blink" ><marquee direction ="up"width="100%" behavior="alternate" scrollamount="2" scrolldelay=".1">' + item.Temp + '</marquee></td>';
                }
                else {
                    object += '<td style="color:black;">' + item.Temp + '</td>';
                }
                object += '<td>' + item.RDName + '</td>'
                object += '<td>' + item.DeviceType + '</td>';
                object += '<td>' + item.DatedOn + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button imei='" + item.IEMINumber + "' href='javascript:void(0); 'title='Details' class='btn btn-primary' onclick='ShowModal();'><i class='fa fa-eye'></i></button></td>"; object += '</tr>';
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

function ShowModal() {
    $('#SaleModalChart').modal('show');
}

function ShowGraf() {

    var options = {
        animationEnabled: true,
        theme: "light2",
        title: {
            text: "LAST 7 DAYS MONITORING"
        },
        axisX: {
        },
        axisY: {
            prefix: "d ",
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
                yValueFormatString: "#,##0",
                dataPoints: [
                    { x: new Date(2022, 10, 10), y: 26.75 },
                    { x: new Date(2022, 10, 11), y: 26.69 },
                    { x: new Date(2022, 10, 12), y: 26.88 },
                    { x: new Date(2022, 10, 13), y: 26.13 },
                    { x: new Date(2022, 10, 14), y: 25.88 },
                    { x: new Date(2022, 10, 15), y: 27.31 },
                    { x: new Date(2022, 10, 16), y: 25.69 },
                    { x: new Date(2022, 10, 17), y: 25.50 },
                    { x: new Date(2022, 10, 18), y: 25.00 },
                ]
            },
            {
                type: "line",
                name: "Average Temp",
                showInLegend: true,
                yValueFormatString: "#,##0",
                dataPoints: [
                    { x: new Date(2022, 10, 10), y: 25.21 },
                    { x: new Date(2022, 10, 11), y: 25.44 },
                    { x: new Date(2022, 10, 12), y: 25.45 },
                    { x: new Date(2022, 10, 13), y: 24.48 },
                    { x: new Date(2022, 10, 14), y: 22.90 },
                    { x: new Date(2022, 10, 15), y: 24.48 },
                    { x: new Date(2022, 10, 16), y: 24.50 },
                    { x: new Date(2022, 10, 17), y: 24.26 },
                    { x: new Date(2022, 10, 18), y: 24.30 },
                ]
            },
            {
                type: "area",
                name: "Low Temp",
                markerBorderColor: "white",
                markerBorderThickness: 2,
                showInLegend: true,
                yValueFormatString: "#,##0",
                dataPoints: [
                    { x: new Date(2022, 10, 10), y: 18.56 },
                    { x: new Date(2022, 10, 11), y: 19.69 },
                    { x: new Date(2022, 10, 12), y: 20.25 },
                    { x: new Date(2022, 10, 13), y: 18.12 },
                    { x: new Date(2022, 10, 14), y: 16.88 },
                    { x: new Date(2022, 10, 15), y: 18.31 },
                    { x: new Date(2022, 10, 16), y: 18.31 },
                    { x: new Date(2022, 10, 17), y: 18.00 },
                    { x: new Date(2022, 10, 18), y: 18.56 },
                ]
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
}




