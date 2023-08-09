a = 1;
$(document).ready(function () {   
   
    ShowCompanyData();
    //*****Device  Start******
    $('#DeviceInfo').show();
    $("#btnAdd").click(function () {
        debugger;
        AddDeviceData();
    });
    $("#btnUpdate").click(function () {
        UpdateDeviceData();
    });
    EditDeviceData();
});
//*******Device Close************

//PDF Export

//********** Document Modal Start Hear*********

function EditDeviceData() {
    //debugger;
    $(document).on("click", "#D_Edit", function () {
        $("#btnAdd").hide();
        $("#btnUpdate").show();
        $("#txtDeviceId").show();
        $("#txtDeviceId").val($(this).parent().parent().find('.DeviceId').html());
        $("#txtIemiNumber").val($(this).parent().parent().find('.IEMINumber').html());
        $("#txtDeviceNumber").val($(this).parent().parent().find('.DeviceNumber').html());
        $("#txtDeviceName").val($(this).parent().parent().find('.DeviceName').html());
        $("#dlDeviceType").val($(this).parent().parent().find('.DeviceType').html());
        $("#txtMinimumValue").val($(this).parent().parent().find('.MinimumValue').html());
        $("#txtMaximumValue").val($(this).parent().parent().find('.MaximumValue').html());
        $("#txtLatitude").val($(this).parent().parent().find('.Latitude').html());
        $("#txtLongitude").val($(this).parent().parent().find('.Longitude').html());
        $("#txtStatus").val($(this).parent().parent().find('.Status').html());
        $("#txtDescription").val($(this).parent().parent().find('.Description').html());
        $(this).parents("tr").remove();
        $("#btnUpdate").focus();
    });
};
function AddDeviceData() {
    debugger;
    let newHtml = GetHtmlDeviceData().replace("$[Device ID]", a++).
        replace("$[IEMI Number]", $("#txtIemiNumber").val()).
        replace("$[Device Number]", $("#txtDeviceNumber").val()).
        replace("$[Device Name]", $("#txtDeviceName").val()).
        replace("$[Device Type]", $("#dlDeviceType").val()).
        replace("$[Minimum Value]", $("#txtMinimumValue").val()).
        replace("$[Maximum Value]", $("#txtMaximumValue").val()).
        replace("$[Latitude]", $("#txtLatitude").val()).
        replace("$[Longitude]", $("#txtLongitude").val()).
        replace("$[Status]", $("#txtStatus").val()).
        replace("$[Description]", $("#txtDescription").val()).
        replace("$[action]", "<i class='fa fa-pencil'></i>");
    $("#table_device").append(newHtml);
    $("#btnAdd").show();
    $('#DeviceInfo').show();
    $("#btnUpdate").hide();
    $('#SaleModal').modal('hide');

}
function GetHtmlDeviceData() {
    debugger;
    return "<tr><td class='DeviceId'>$[Device ID]</td>"
        + "<td class='IEMINumber'>$[IEMI Number]</td>"
        + "<td class='DeviceNumber'>$[Device Number]</td>"
        + "<td class='DeviceName'>$[Device Name]</td>"
        + "<td class='DeviceType'>$[Device Type]</td>"
        + "<td class='MinimumValue'>$[Minimum Value]</td>"
        + "<td class='MaximumValue'>$[Maximum Value]</td>"
        + "<td class='Latitude'>$[Latitude]</td>"
        + "<td class='Longitude'>$[Longitude]</td>"
        + "<td class='Status'>$[Status]</td>"
        + "<td class='Description'>$[Description]</td>"
        + "<td class='action'><a href='#' id='D_Edit'> $[action] </a> </td></tr>";
}

function AddDevice() {
    var fbStatus;
    $('#DeviceId').css('display', 'block');
    $('#btnUpdate').css('display', 'none');
    debugger;
    if ($("#txtStatus").is(':checked'))
    {
        fbStatus = true;
    }
    else
    {
        fbStatus = false;
    }
    var objdata = {
        IEMINumber: $('#txtIemiNumbers').val(),
        DeviceNumber: $('#txtDeviceNumber').val(),
        DeviceName: $('#txtDeviceName').val(),
        DeviceType: $('#dlDeviceType').val(),
        MaximumValue: $('#txtMaximumValue').val(),
        MinimumValue: $('#txtMinimumValue').val(),
        Latitude: $('#txtLatitude').val(),
        Longitude: $('#txtLongitude').val(),
    //   Status: $('#txtStatus').val(),
        Status: fbStatus,
        Description: $('#txtDescription').val(),
    }
    debugger;
    $.ajax({
        url: '/DeviceDetail/AddDevice',
        type: 'POST',
        data: objdata,
        dataType: "json",
        crossDomain: true,
        contentType: "application/x-www-form-urlencoded",
        success: function () {
            //    alert('data Save');
            ShowCompanyData();
        },
        error: function () {
            alert('Data not save');
        }
    })
}

function ShowCompanyData() {
    $("#searchrec").on("keyup", function () {

        var value = $(this).val().toLowerCase();

        $("#table_device tr").filter(function () {

            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
    //debugger;
    $.ajax({
        url: '/DeviceDetail/GetDeviceDetail',
        type: 'get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result, status, xhr) {
            //debugger;
            var object = '';
            //debugger;
            $.each(result, function (index, item) {
                //debugger;
                object += '<tr>';
                object += '<td>' + (index + 1) +'</td>';
                object += '<td>' + item.Ieminumber + '</td>';
                object += '<td>' + item.DeviceNumber + '</td>';
                object += '<td>' + item.DeviceName + '</td>';
                object += '<td>' + item.DeviceType + '</td>';
                object += '<td>' + item.MaximumValue + '</td>';
                object += '<td>' + item.MinimumValue + '</td>';
                object += '<td>' + item.Latitude + '</td>';
                object += '<td>' + item.Longitude + '</td>';
                object += '<td>' + item.Branch + '</td>';
                object += '<td>' + item.RegionName + '</td>';
                object += '<td>' + item.Asmarea + '</td>';
                object += '<td>' + item.Soterritory + '</td>';
                object += '<td>' + item.Rdcode + '</td>';
                object += '<td>' + item.Rdname + '</td>';
                object += '<td>' + item.TownClassName + '</td>';
                object += '<td>' + item.Rdtown + '</td>';
                object += '<td>' + item.Status + '</td>';
                object += '<td>' + item.Description + '</td>';
                object += '<td> <button class="btn btn-primary" onclick="Edit(' + item.deviceId + ')"><i class="fa fa-pen"></i></button> &nbsp;<button class="btn btn-danger" onclick="Delete(' + item.deviceId + ')"><i class="fa fa-trash"></i></button> </td>';

                object += '</tr>';
            })
            $('#table_device').html(object);
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

//(***update****)
function UpdateDeviceData() {
    debugger;
    var fbStatus;
    $("#SaleModal").modal('hide');
    if ($("#txtStatus").is(':checked')) {
        fbStatus = true;
    }
    else {
        fbStatus = false;
    }
    var objdata = {
        DeviceId: $('#txtDeviceId').val(),
        IEMINumber: $('#txtIemiNumbers').val(),
        DeviceNumber: $('#txtDeviceNumber').val(),
        DeviceName: $('#txtDeviceName').val(),
        DeviceType: $('#dlDeviceType').val(),
        MaximumValue: $('#txtMaximumValue').val(),
        MinimumValue: $('#txtMinimumValue').val(),
        Latitude: $('#txtLatitude').val(),
        Longitude: $('#txtLongitude').val(),
        Branch: $('#txtBranch').val(),
        RegionName: $('#txtRegionName').val(),
        ASMArea: $('#txtASMArea').val(),
        Soterritory: $('#txtSoterritory').val(),
        RDCode: $('#txtRDCode').val(),
        RDName: $('#txtRDName').val(),
        TownClassName: $('#txtTownClassName').val(),
        RDTown: $('#txtRDTown').val(),
      //  Status: $('#txtStatus').val(),
        Status: fbStatus,
        Description: $('#txtDescription').val(),
    }
    $.ajax({
        url: '/DeviceDetail/UpdateDevice',
        type: 'POST',
        data: objdata,
        dataType: "json",
        crossDomain: true,
        contentType: "application/x-www-form-urlencoded",
        success: function () {
            debugger;
            alert('Record Updated');
            ShowCompanyData();
            $("#SaleModal").modal('hide');
        },
        error: function () {
            debugger;
            alert('Data not save');
        }
    })
}

function Delete(DeviceId) {
    
    // $("#SaleModal").modal('show');
   // debugger;
    $.ajax({
        url: '/DeviceDetail/Delete?DeviceId=' + DeviceId,
        type: 'get',
        contentType: 'application/json;charset=utf-8;',
        dataType: 'json',
        success: function (response) {
            ShowCompanyData();
            alert('data Delete');
        },
        error: function () {
            alert('data not found');
        }
    })
};

function Edit(DeviceId) {
 //   alert("edit device");
    $("#SaleModal").modal('show');
  //  debugger;
    $.ajax({
        url: '/DeviceDetail/Edit?DeviceId=' + DeviceId,
        type: 'get',
        contentType: 'application/json;charset=utf-8;',
        dataType: 'json',
        success: function (response) {
            $('#SaleModal').modal('show');
            $('#txtDeviceId').val(response.deviceId);
            $('#txtIemiNumbers').val(response.ieminumber);
            $('#txtDeviceNumber').val(response.deviceNumber);
            $('#txtDeviceName').val(response.deviceName);
            $('#dlDeviceType').val(response.deviceType);
            $('#txtMaximumValue').val(response.maximumValue);
            $('#txtMinimumValue').val(response.minimumValue);
            $('#txtLatitude').val(response.latitude);
            $('#txtLongitude').val(response.longitude);           
            $('#txtBranch').val(response.branch);
            $('#txtRegionName').val(response.regionName);
            $('#txtASMArea').val(response.asmarea);
            $('#txtSoterritory').val(response.soterritory);
            $('#txtRDCode').val(response.rdcode);
            $('#txtRDName').val(response.rdname);
            $('#txtTownClassName').val(response.townClassName);
            $('#txtRDTown').val(response.rdtown);
            $('#txtStatus').val(response.status);
            $('#txtDescription').val(response.description);
            $('#btnAdd').css('display', 'none');
            $('#btnUpdate').css('display', 'block');
            $('#SaleModal').modal('show');
        },
        error: function () {
            alert('data not found');
        }
    })
};