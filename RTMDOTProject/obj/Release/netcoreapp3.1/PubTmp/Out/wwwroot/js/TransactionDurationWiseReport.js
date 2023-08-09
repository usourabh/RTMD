$(document).ready(function () {
    $("#dFrom").datepicker({ dateFormat: 'dd-M-yy' });
    $("#dTo").datepicker({ dateFormat: 'dd-M-yy' });
    ShowDeviceTransactionData();
    $('#DeviceInfo tbody').on('click', 'td.details-control', function () {
        var txtdFrom = $('#dFrom').val();
        var txtdTo = $('#dTo').val();
        var txtaging = $('#aging').val();
        var tr = $(this).closest('tr');
        var rownext = $(this).closest('tr').next('tr');

        var ticketid = tr.attr('ticketid');
        if ((tr.hasClass('shown'))) {
            rownext.hide();
            tr.removeClass('shown');
        }
        else {
            // Open this row
            $.ajax({
                url: "/Report/TransactionById",
                type: "POST",
                dataType: "json",
                data: { dF: txtdFrom, dT: txtdTo, imei: ticketid, minutes: txtaging },
                success: function (data) {
                    var jData = JSON.parse(data);
                    var txtChildTable = '';
                    txtChildTable += '<tr>';
                    txtChildTable += '<td colspan="18">';
                    txtChildTable += formatVehicle(jData);
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
    var InnerGrid = '<div class="table-scrollable vehicletable" style="padding-left:10px;margin:10px;"><table class="table"><thead><tr><th>Sr. No.</th><th>Box Number </th><th> Temperature </th><th> Latitude and Longitude</th><th>Lid Status </th><th> View On Map </th><th> Dated On </th></tr></thead><tbody>';
    if (item != null && item.length > 0) {
        $.each(item, function (i, info) {
            InnerGrid += '<tr>';


            var latlng = info.Lat + "," + info.Lng;

            InnerGrid += '<td>' + (i + 1) + '</td>' +
                '<td>' + info.Imei + '</td>' +
                '<td>' + info.Temp + '</td>' +
                '<td>' + latlng + '</td>' +
                '<td>' + info.Status + '</td>' +
                '<td><a data-cordinates="' + info.Lat + "," + info.Lng + '" data-datedon="' + info.DatedOn + '" data-rdname="' + info.RDName + '" data-temp="' + info.Temp + '" data-Status="' + info.Status + '" data-imei="' + info.Imei + '"  href="javascript:void(0)" onclick="ShowMapPopup(this);">View On Map</a></td>' +
                '<td>' + info.DatedOn + '</td>' +
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
        url: "/Report/TransactionDurationWiseReport",
        type: 'POST',
        dataType: 'json',
        data: { dFrom: $('#dFrom').val(), dTo: $('#dTo').val() },
        success: function (strresult) {
            var result = JSON.parse(strresult);
            var object = '';
            $.each(result, function (index, item) {
                object += '<tr ticketid="' + item.IEMINumber + '">';
                object += '<td  class="details-control"></td>';
                if (item.Img1 == '/images/')
                    object += '<td></td>';
                else
                    object += '<td><a onclick="VeiwImage(this);" dataurl="http://tsen.ecosmartdc.com' + item.Img1 + '" data-gallery="photoviewer" href="javascript:void(0)" data-group="b"><img height="100" src="http://tsen.ecosmartdc.com/' + item.Img1 + '" alt="" /></a><a style="display:none" dataurl="http://tsen.ecosmartdc.com' + item.Img2 + '" data-gallery="photoviewer" href="javascript:void(0)" data-group="b"></a><a style="display:none" dataurl="http://tsen.ecosmartdc.com' + item.Img3 + '" data-gallery="photoviewer" href="javascript:void(0)" data-group="b"></a></td>';

                if (parseFloat(item.Temp) > 24 || parseFloat(item.Temp) < 18) {
                    object += '<td style="color:red;"class="blink" ><marquee direction ="up"width="100%" behavior="alternate" scrollamount="2" scrolldelay=".1">' + item.Temp + '</marquee></td>';
                }
                else {
                    object += '<td style="color:black;">' + item.Temp + '</td>';
                }
                object += '<td>' + item.InstalledOn + '</td>';
                object += '<td>' + item.ApprovedPersonMobileNo + '</td>';
                object += '<td>' + item.RDName + '</td>';
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
                object += '</tr>';
            })

            $('#DeviceInfo > tbody').html(object);

            $('#DeviceInfo').dataTable({
                dom: 'Bfrtip',
                "bDestroy": true,
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


    contentString = "<div style='float:right;width:300px; padding: 10px;font-size: 14px;background-color: #33414E;color: white;'>" +
        "<br/>RD Name- " + RdName +
        "<br/>Temperature- " + temp +
        "<br/>Box Number-" + Imei +
        "<br/>Lid Status- " + status +
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















