$(document).ready(function () {
    $('.abc').hide();
    $('h3').hide();   
    $('#dlDeviceType').change(function () {
        debugger;
        if ($(this).val() == 3) {
            $('.abc').show();
            $('h3').show();           
            DdlDevice();
        }
        else {
            $('.abc').hide();
            $('h3').hide();
        }
    });
    ShowDeviceData();

 //*****Device  Start******
    $('#DeviceInfo').show();
   //*******Device Close************
    $('#btnUpdate').css('display', 'none');


});

//dropdown binding in form from db using jquery ajax

function DdlDevice() {
    $.ajax({
        url: '/DeviceDetail/getPrimaryDevice',
        type: 'get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result, status, xhr) {          
            $.each(result, function (index, item) {
                debugger
                $("#textDeviceId").append($("<option></option>").val(item.DeviceMasterId).html(item.ImeiNo));

            })       
        },
        error: function () {
            alert("data can't get");
        }
    });
}

//to add Device record

function AddDevice() {
    var fbStatus;
    var Associate;
    
    if ($("#ckIsActive").is(':checked')) {
        fbStatus = true;
    }
    else {
        fbStatus = false;
    }
    if ($("#txtAssociated").is(':checked')) {
        Associate = true;
    }
    else {
        Associate = false;
    }
    var objdata = {
       DeviceMasterId: $('#txtDMasterId').val(),
        ImeiNo: $('#txtImeiNumber').val(),
        SerialNo: $('#txtSerialNumber').val(),
        DeviceTypeId: $('#dlDeviceType option:selected').val(),
        RangeMax: $('#txtMaxValue').val(),
        RangeMin: $('#txtMinValue').val(),
        Make: $('#txtMake').val(),
        Model: $('#txtModel').val(),
        Lat: $('#txtLat').val(),
        Lng: $('#txtLng').val(),
        IsActive: fbStatus,
        Description: $('#txtDescription').val(),
        DeviceId: $('#textDeviceId option:selected').val(),
        IsAssociated: Associate,
        PrimaryDeviceId: $('#txtImeiNumber').val(),
    }
    debugger;
    $.ajax({
        url: '/DeviceDetail/DeviceInfo',
        type: 'POST',
        data: objdata,
        dataType: "json",
        crossDomain: true,
        contentType: "application/x-www-form-urlencoded",
        success: function () {
            ShowDeviceData();
            $('#SaleModal').modal('hide');

        },
        error: function () {
            alert('Data not save');
        }
    })
}

//to show details of devices in grid table
function ShowDeviceData() {
    $("#searchrec").on("keyup", function () {

        var value = $(this).val().toLowerCase();

        $("#table_device tr").filter(function () {

            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
    $.ajax({
        url: '/DeviceDetail/GetMasterData',
        type: 'get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result, status, xhr) {
            var result = JSON.parse(result);
            var object = '';            
            $.each(result, function (index, item) {
                object += '<tr>';
                object += '<td>' + (index + 1) + '</td>';
                object += '<td>' + item.ImeiNo + '</td>';
                object += '<td>' + item.DeviceName + '</td>';
                object += '<td>' + item.SerialNo + '</td>';
                object += '<td>' + item.Make + '</td>';
                object += '<td>' + item.Model + '</td>';
                object += '<td>' + item.RangeMax + '</td>';
                object += '<td>' + item.RangeMin + '</td>';
                object += '<td>' + item.Lng + '</td>';
                object += '<td>' + item.Lat + '</td>';
                if (item.IsActive == true)
                {
                    object += '<td>Active</td>';
                }
                else {
                    object += '<td>InActive</td>';
                }
                object += '<td>' + item.Description + '</td>';
                object += '<td> <button class="btn btn-primary" onclick="Edit(' + item.DeviceMasterId + ')"><i class="fa fa-pen"></i></button> &nbsp;<button class="btn btn-danger" onclick="Delete(' + item.DeviceMasterId + ')"><i class="fa fa-trash"></i></button> </td>';
                object += '</tr>';
            })
            $('#table_device').html(object);

            $('#DeviceInfo').dataTable({
                destroy: true,
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

//(***update****)
function UpdateDeviceData() {
    debugger;
    var fbStatus;
    var Associate;
    $("#SaleModal").modal('hide');
    if ($("#ckIsActive").is(':checked')) {
        fbStatus = true;
    }
    else {
        fbStatus = false;
    }
    if ($("#txtAssociated").is(':checked')) {
        Associate = true;
    }
    else {
        Associate = false;
    }
    var objdata = {
        DeviceMasterId: $('#txtDMasterId').val(),
        ImeiNo: $('#txtImeiNumber').val(),
        SerialNo: $('#txtSerialNumber').val(),
        DeviceTypeId: $('#dlDeviceType option:selected').val(),
        RangeMax: $('#txtMaxValue').val(),
        RangeMin: $('#txtMinValue').val(),
        Make: $('#txtMake').val(),
        Model: $('#txtModel').val(),
        Lat: $('#txtLat').val(),
        Lng: $('#txtLng').val(),
        IsActive: fbStatus,
        Description: $('#txtDescription').val(),
        DeviceId: $('#textDeviceId option:selected').val(),
        IsAssociated: Associate,
        PrimaryDeviceId: $('#txtImeiNumber').val(),
    }
    $.ajax({
        url: '/DeviceDetail/UpdateData',
        type: 'POST',
        data: objdata,
        dataType: "json",
        crossDomain: true,
        contentType: "application/x-www-form-urlencoded",
        success: function () {
            ShowDeviceData();
        },
        error: function () {
            debugger;
            alert('Data not save');
        }
    })
}


//delete device records
function Delete(DeviceMasterId) {
    $.ajax({
        url: '/DeviceDetail/Deletedata?DeviceMasterId=' + DeviceMasterId,
        type: 'get',
        contentType: 'application/json;charset=utf-8;',
        dataType: 'json',
        success: function (response) {            
            alert('Record  Deleted');
            ShowDeviceData();
        },
        error: function () {
            alert('data not found');
        }
    })
};


//edit existing records
function Edit(DeviceMasterId) {
    $("#SaleModal").modal('show');
    $.ajax({
        url: '/DeviceDetail/Editdata?DeviceMasterId=' + DeviceMasterId,
        type: 'get',
        contentType: 'application/json;charset=utf-8;',
        dataType: 'json',
        success: function (response) {
            debugger
            $('#SaleModal').modal('show');
            $('#txtDMasterId').val(response.DeviceMasterId);
            $('#txtImeiNumber').val(response.ImeiNo);
            $('#txtSerialNumber').val(response.SerialNo);
            $('#dlDeviceType').val(response.DeviceTypeId);
            $('#txtMaxValue').val(response.RangeMax);
            $('#txtMinValue').val(response.RangeMin);
            $('#txtMake').val(response.Make);
            $('#txtModel').val(response.Model);
            $('#txtLat').val(response.Lat);
            $('#txtLng').val(response.Lng);
            $('#ckIsActive').val(response.IsActive);
            $('#txtDescription').val(response.Description);
            $('#textDeviceId').val(response.DeviceId);
            $('#txtAssociated').val(response.IsAssociated);
            $('#txtImeiNumber').val(response.PrimaryDeviceId);
            $('#btnAdd').css('display', 'none');
            $('#btnUpdate').css('display', 'block');
            $('#txtImeiNumber').val(response.ImeiNo).show();
            $('#SaleModal').modal('show');
        },
        error: function () {
            alert('data not found');
        }
    })
};