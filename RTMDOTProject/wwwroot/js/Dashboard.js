$(document).ready(function () {
    $('#DeviceInfo #table_device tr').each(function (index) {
        $(this).children("td:eq(0)").html(index + 1);
        $('#DeviceInfo').DataTable({
        });
    });
});

function ShowCompanyData() {
    $.ajax({
        url: '/Dashboard/GetDeviceDetail',
        type: 'get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result, status, xhr) {
            
            var object = '';
            
            $.each(result, function (index, item) {
                
                object += '<tr>';
                object += '<td>'+(index+1)+'</td>';
                object += '<td>' + item.ieminumber + '</td>';
                object += '<td>' + item.deviceNumber + '</td>';
                object += '<td>' + item.deviceName + '</td>';
                object += '<td>' + item.deviceType + '</td>';
                object += '<td>' + item.maximumValue + '</td>';
                object += '<td>' + item.minimumValue + '</td>';
                object += '<td>' + item.latitude + '</td>';
                object += '<td>' + item.longitude + '</td>';
                object += '<td>' + item.status + '</td>';
                object += '<td>' + item.description + '</td>';
                object += '<td> <button class="btn btn-primary" onclick="Edit(' + item.deviceId + ')"><i class="fa fa-pencil"></i></button> </td>';

                object += '</tr>';
            })
            $('#table_device').html(object);
        },
        error: function () {
            alert("data can't get");
        }
    });
};

function ShowActiveDeviceData() {
    debugger;
    $.ajax({
        url: '/Dashboard/GetActiveDeviceDetail',
        type: 'get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result, status, xhr) {
            debugger;
            var object = '';
            debugger;
            $.each(result, function (index, item) {
                debugger;
                object += '<tr>';
                object += '<td>' + (index + 1) +'</td>';
                object += '<td>' + item.ieminumber + '</td>';
                object += '<td>' + item.deviceNumber + '</td>';
                object += '<td>' + item.deviceName + '</td>';
                object += '<td>' + item.deviceType + '</td>';
                object += '<td>' + item.maximumValue + '</td>';
                object += '<td>' + item.minimumValue + '</td>';
                object += '<td>' + item.latitude + '</td>';
                object += '<td>' + item.longitude + '</td>';
                object += '<td>' + item.status + '</td>';
                object += '<td>' + item.description + '</td>';
                object += '<td> <button class="btn btn-primary" onclick="Edit(' + item.deviceId + ')"><i class="fa fa-pencil"></i></button> </td>';

                object += '</tr>';
            })
            $('#table_device').html(object);
        },
        error: function () {
            alert("data can't get");
        }
    });
};

function ShowInActiveDeviceData() {
    debugger;
    $.ajax({
        url: '/Dashboard/GetInActiveDeviceDetail',
        type: 'get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result, status, xhr) {
            debugger;
            var object = '';
            debugger;
            $.each(result, function (index, item) {
                debugger;
                object += '<tr>';
                object += '<td>' + (index + 1) +'</td>';
                object += '<td>' + item.ieminumber + '</td>';
                object += '<td>' + item.deviceNumber + '</td>';
                object += '<td>' + item.deviceName + '</td>';
                object += '<td>' + item.deviceType + '</td>';
                object += '<td>' + item.maximumValue + '</td>';
                object += '<td>' + item.minimumValue + '</td>';
                object += '<td>' + item.latitude + '</td>';
                object += '<td>' + item.longitude + '</td>';
                object += '<td>' + item.status + '</td>';
                object += '<td>' + item.description + '</td>';
                object += '<td> <button class="btn btn-primary" onclick="Edit(' + item.deviceId + ')"><i class="fa fa-pencil"></i></button> </td>';

                object += '</tr>';
            })
            $('#table_device').html(object);
        },
        error: function () {
            alert("data can't get");
        }
    });
};

function ShowDeviceTransactionData() {
    debugger;
    $.ajax({
        url: "/Dashboard/getMaxDevice",
        type: 'get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result) {
            var object = '';
            $.each(result, function (index, item) {
                //if (item.temp > 22 || item.temp < 18)
                //    var mm = mm + 1;
                object += '<tr ticketid="' + item.imei + '">';
                object += '<td  class="details-control"></td>';
                object += '<td>' + item.imei + '</td>';
                object += '<td>' + item.temp + '</td>';             
                object += '<td>' + item.deviceType + '</td>';
                object += '<td>' + item.datedOn + '</td>';
                object += '</tr>';
            })
            $('#DeviceInfo > tbody').html(object);
        },
        error: function () {
            alert("data can't get");
        }
    });
};

