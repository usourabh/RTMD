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
                success: function (jdata) {
                    var data = JSON.parse(jdata);
                    var txtChildTable = '';
                    txtChildTable += '<tr>';
                    txtChildTable += '<td colspan="18">';
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
    var InnerGrid = '<div class="table-scrollable vehicletable" style="padding-left:10px;margin:10px;"><table class="table"><thead><tr><th>Sr. No.</th><th>IMEI Number </th><th> Latitude and Longitude</th><th> Carbon Ratio </th><th> View On Map </th><th> Dated On </th><th> Location Status </th></tr></thead><tbody>';
    if (item != null && item.length > 0) {
        $.each(item, function (i, info) {
            if (info.CurrentActionStatus == 2 || info.TotalMin > 15)
                InnerGrid += '<tr style="background-color:#FFCCCB">';
            else
                InnerGrid += '<tr>';

            var latlng = info.Lat + "," + info.Lng;

            InnerGrid += '<td>' + (i + 1) + '</td>' +
                '<td>' + info.Imei + '</td>' +
                '<td>' + latlng + '</td>' +
                '<td>' + info.Status + '</td>' +
                '<td><a data-cordinates="' + info.Lat + "," + info.Lng + '" data-datedon="' + info.DatedOn + '" data-rdname="' + info.RDName + '" data-temp="' + info.Temp + '" data-Status="' + info.Status + '" data-imei="' + info.Imei + '"  href="javascript:void(0)" onclick="ShowMapPopup(this);">View On Map</a></td>' +
                '<td>' + info.DatedOn + '</td>' +
                '<td>' + info.LocationStatus + '</td>' +
                '</tr>';

            var txtChildTable = '';
            txtChildTable += '<tr class="dvacctiondetail" style="display:none">';
            txtChildTable += '<td colspan="18">';
            txtChildTable += '</td>';
            txtChildTable += '</tr>';
            InnerGrid += txtChildTable;
        });

        InnerGrid += '</tbody></table></div>';
    }
    else {
        InnerGrid += '<tr><td colspan="18">No Item</td></tr></tbody></table></div>';
    }



    return InnerGrid;
}

function ShowDeviceTransactionData() {
    $.ajax({
        url: "/DeviceTransaction/InActiveDeviceTransaction",
        type: 'get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (strresult) {
            var result = JSON.parse(strresult);
            var object = '';
            $.each(result, function (index, item) {
                object += '<tr ticketid="' + item.IEMINumber + '">';
                object += '<td  class="details-control"></td>';
                object += '<td>' + (index + 1) + '</td>';
                //if (item.Img1 == '/images/')
                //    object += '<td></td>';
                //else
                //    object += '<td><a onclick="VeiwImage(this);" dataurl="http://tsen.ecosmartdc.com' + item.Img1 + '" data-gallery="photoviewer" href="javascript:void(0)" data-group="b"><img height="100" src="http://tsen.ecosmartdc.com/' + item.Img1 + '" alt="" /></a><a style="display:none" dataurl="http://tsen.ecosmartdc.com' + item.Img2 + '" data-gallery="photoviewer" href="javascript:void(0)" data-group="b"></a><a style="display:none" dataurl="http://tsen.ecosmartdc.com' + item.Img3 + '" data-gallery="photoviewer" href="javascript:void(0)" data-group="b"></a></td>';

               
                //object += '<td>' + item.InstalledOn + '</td>';
                //object += '<td>' + item.ApprovedPersonMobileNo + '</td>';
                //object += '<td>' + item.RDName + '</td>';
                //object += '<td>' + item.Phone + '</td>';
                //object += '<td>' + item.ContactPerson + '</td>';
                //object += '<td>' + item.Branch + '</td>';
                //object += '<td>' + item.RegionName + '</td>';
                //object += '<td>' + item.ASMArea + '</td>';
                //object += '<td>' + item.Soterritory + '</td>';
                //object += '<td>' + item.IEMINumber + '</td>';
                //object += '<td>' + item.DeviceType + '</td>';
                //object += '<td>' + item.EmailId + '</td>';
                //object += '<td>' + item.DatedOn + '</td>';
                //object += '</tr>';

              
                object += '<td>' + item.Img1 + '</td>';
                object += '<td>' + item.RDCode + '</td>';
                object += '<td>' + item.RDName + '</td>';
                object += '<td>' + item.Address + '</td>';
                object += '<td>' + item.IEMINumber + '</td>';
                object += '<td>' + item.VisicoolerSerialNo + '</td>';
                object += '<td>' + item.QrCodeNumber + '</td>';
                object += '<td>' + item.Phone + '</td>';
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

function VeiwImage(objthis) {

    var td = $(objthis).parent();

    var items = [],
        options = {
            index: 0,
            headerToolbar: [
                'minimize',
                'maximize',
                'close'
            ],
            footerToolbar: [
                'prev',
                'next',
                'zoomIn',
                'zoomOut',
                'fullscreen',
                'actualSize',
                'rotateLeft',
                'rotateRight',
                'myCustomButton',
            ],
            customButtons: {
                myCustomButton: {
                    text: 'custom!',
                    title: 'custom!'
                }
            },
            modalWidth: 400,
            modalHeight: 400,
            callbacks: {
                beforeChange: function (context, index) {
                    console.log(context, index)
                },
                changed: function (context, index) {
                    console.log(context, index)
                }
            }
        };

    $(td).find('[data-gallery=photoviewer]').each(function () {
        items.push({
            src: $(this).attr('dataurl'),
            title: $(this).attr('data-title')
        });
    });
    new PhotoViewer(items, options);
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

var circle;
function DumyardCircle(map, l1, l2) {

    if (circle != undefined)
        circle.setMap(null);

    var radius = 300;

    var options = {
        strokeColor: '#013220',
        strokeOpacity: 1.0,
        strokeWeight: 3,
        fillColor: '#013220',
        fillOpacity: 0.2,
        map: map,
        center: new google.maps.LatLng(l1, l2),
        radius: radius
    };

    circle = new google.maps.Circle(options);
}
function ShowMapPopup(objthis) {
    var Cordinates = $(objthis).attr('data-Cordinates').split(',');
    var lat = Cordinates[0];
    var lng = Cordinates[1];
    var temp = $(objthis).attr('data-temp');
    var Imei = $(objthis).attr('data-imei');
    var status = $(objthis).attr('data-status');
    var RdName = $(objthis).attr('data-rdname');
    var DatedOn = $(objthis).attr('data-datedon');

    var mapOptions = {
        center: new google.maps.LatLng(lat, lng),
        zoom: 14,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    }
    var map = new google.maps.Map($("#dvIMap")[0], mapOptions);

    var infowindow = new google.maps.InfoWindow();
    var marker1, i;
    var iconBase = '../otherfiles/assets/img/map/green-dot.png';
    DumyardCircle(map, lat, lng);

    contentString = "<div style='float:right;width:300px; padding: 10px;font-size: 14px;background-color: #33414E;color: white;'>" +
        "<br/>RD Name- " + RdName +
        "<br/>IMEI Number-" + Imei +
        "<br/>Carbon ratio- " + status +
        "<br/>Sync On- " + DatedOn +
        "</div>";
    marker1 = new google.maps.Marker({
        position: new google.maps.LatLng(lat, lng),
        map: map,
        icon: iconBase,
        content: contentString

    });

    google.maps.event.addListener(marker1, 'mouseover', (function (marker1, i) {
        return function () {
            infowindow.setContent(marker1.content);
            infowindow.open(map, marker1);
        }
    })(marker1, i));
    google.maps.event.addListener(marker1, 'mouseout', (function (marker1, i) {
        return function () {
            infowindow.close(map, marker1);
        }
    })(marker1, i));

    $('#viewonmap').modal('toggle');

    return false;
}













