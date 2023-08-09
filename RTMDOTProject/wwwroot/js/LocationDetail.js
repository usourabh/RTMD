

a = 1;
$(document).ready(function () {
    ShowCompanyData();
    //*****Device  Start******
    $('#DeviceInfo').show();
    $("#btnAdd1").click(function () {
        debugger;
        AddDeviceData();
    });
    $("#btnUpdate1").click(function () {
        debugger;
        UpdateDeviceData();
    });
    EditDeviceData();
    DeleteDeviceData();
});

//*******Device Close************

//********** Document Modal Start Hear*********
function DeleteDeviceData() {
    debugger;
    $(document).on("click", "#E_delete", function () {
        $(this).parents("tr").remove();
    });
}
function EditDeviceData() {
    debugger;
    $(document).on("click", "#E_Edit", function () {
        $("#btnAdd1").hide();
        $("#btnUpdate1").show();
        $("#txtContactId").show();
        $("#txtContactId").val($(this).parent().parent().find('.ContactId').html());
        $("#txtContactPersonName").val($(this).parent().parent().find('.ContactPersonName').html());
        $("#txtContactPersonNumber").val($(this).parent().parent().find('.ContactPersonNumber').html());
        $("#txtAddress1").val($(this).parent().parent().find('.Address1').html());
        $("#txtAddress2").val($(this).parent().parent().find('.Address2').html());
        $("#txtLongitude").val($(this).parent().parent().find('.Longitude').html());
        $("#txtLatitude").val($(this).parent().parent().find('.Latitude').html());
        $("#txtCity").val($(this).parent().parent().find('.City').html());
        $("#txtState").val($(this).parent().parent().find('.State').html());
        $("#txtPin").val($(this).parent().parent().find('.Pin').html());
        $("#txtCountry").val($(this).parent().parent().find('.Country').html());
        $(this).parents("tr").remove();
        $("#btnUpdate1").focus();
    });
};
function UpdateDeviceData() {
    debugger;
    let newHtml = GetHtmlDeviceData().replace("$[Contact ID]", $("#txtContactId").val()).
        replace("$[Contact Person Name]", $("#txtContactPersonName").val()).
        replace("$[Contact Person Number]", $("#txtContactPersonNumber").val()).
        replace("$[Address1]", $("#txtAddress1").val()).
        replace("$[Address2]", $("#txtAddress2").val()).
        replace("$[Longitude]", $("#txtLongitude").val()).
        replace("$[Latitude]", $("#txtLatitude").val()).
        replace("$[City]", $("#txtCity").val()).
        replace("$[State]", $("#txtState").val()).
        replace("$[Pin]", $("#txtPin").val()).
        replace("$[Country]", $("#txtCountry").val()).
        replace("$[action]", "EDIT");
    $("#table_location").append(newHtml);
    $("#btnUpdate1").show();
    $("#txtContactId").val('');
    $("#txtContactPersonName").val('');
    $("#txtContactPersonNumber").val('');
    $("#txtAddress1").val('');
    $("#txtAddress2").val('');
    $("#txtLongitude").val('');
    $("#txtLatitude").val('');
    $("#txtCity").val('');
    $("#txtState").val('');
    $("#txtPin").val('');
    $("#txtCountry").val('');
}
function AddDeviceData() {
    debugger;
    let newHtml = GetHtmlDeviceData().replace("$[Contact ID]", a++).
        replace("$[Contact Person Name]", $("#txtContactPersonName").val()).
        replace("$[Contact Person Number]", $("#txtContactPersonNumber").val()).
        replace("$[Address1]", $("#txtAddress1").val()).
        replace("$[Address2]", $("#txtAddress2").val()).
        replace("$[Longitude]", $("#txtLongitude").val()).
        replace("$[Latitude]", $("#txtLatitude").val()).
        replace("$[City]", $("#txtCity").val()).
        replace("$[State]", $("#txtState").val()).
        replace("$[Pin]", $("#txtPin").val()).
        replace("$[Country]", $("#txtCountry").val()).
        replace("$[action]", "EDIT");
    $("#table_location").append(newHtml);
    $("#btnAdd1").show();
    $('#DeviceInfo').show();
    $("#btnUpdate1").hide();
    $('#SaleModal').modal('hide');
}
function GetHtmlDeviceData() {
    debugger;
    return "<tr><td class='ContactId'>$[Contact ID]</td>"
        + "<td class='ContactPersonName'>$[Contact Person Name]</td>"
        + "<td class='ContactPersonNumber'>$[Contact Person Number]</td>"
        + "<td class='Address1'>$[Address1]</td>"
        + "<td class='Address2'>$[Address2]</td>"
        + "<td class='Longitude'>$[Longitude]</td>"
        + "<td class='Latitude'>$[Latitude]</td>"
        + "<td class='City'>$[City]</td>"
        + "<td class='State'>$[State]</td>"
        + "<td class='Pin'>$[Pin]</td>"
        + "<td class='Country'>$[Country]</td>"
        + "<td class='action'><button id='E_Edit'> $[action] </button> </td></tr>";
}
//*******device ends**************



function AddLocation() {
    $('#ContactId').css('display', 'block');
    //  $('#lblCompanyId').css('display', 'block');
    $('#btnUpdate1').css('display', 'none');
    debugger;
    var objdata = {
        ContactPersonName: $('#txtContactPersonName').val(),
        ContactPersonNumber: $('#txtContactPersonNumber').val(),
        Address1: $('#txtAddress1').val(),
        Address2: $('#txtAddress2').val(),
        Longitude: $('#txtLongitude').val(),
        Latitude: $('#txtLatitude').val(),
        City: $('#txtCity').val(),
        State: $('#txtState').val(),
        Pin: $('#txtPin').val(),
        Country: $('#txtCountry').val(),
    }
    $.ajax({
        url: '/Location/AddLocation',
        type: 'POST',
        data: objdata,
        dataType: "json",
        crossDomain: true,
        contentType: "application/x-www-form-urlencoded",

        success: function () {
            alert('data Save');
            ShowCompanyData();
        },
        error: function () {
            alert('Data not save');
        }
    })
}

function ShowCompanyData() {
    debugger;
    $.ajax({
        url: '/Location/GetLocationDetail',
        type: 'get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result, status, xhr) {
            var object = '';
            $.each(result, function (index, item) {
                object += '<tr>';
                object += '<td>' + item.contactId + '</td>';
                object += '<td>' + item.contactPersonName + '</td>';
                object += '<td>' + item.contactPersonNumber + '</td>';
                object += '<td>' + item.address1 + '</td>';
                object += '<td>' + item.address2 + '</td>';
                object += '<td>' + item.longitude + '</td>';
                object += '<td>' + item.latitude + '</td>';
                object += '<td>' + item.city + '</td>';
                object += '<td>' + item.state + '</td>';
                object += '<td>' + item.pin + '</td>';
                object += '<td>' + item.country + '</td>';
                object += '<td> <button class="btn btn-primary" onclick="Edit(' + item.contactId + ')">Edit</button> </td>';

                object += '</tr>';
            })
            $('#table_location').html(object);
        },
        error: function () {
            alert("data can't get");
        }
    });
};
//(***update****)
function UpdateLocation() {
    debugger;
    var objdata = {       
        ContactId: $('#txtContactId').val(),
        ContactPersonName: $('#txtContactPersonName').val(),
        ContactPersonNumber: $('#txtContactPersonNumber').val(),
        Address1: $('#txtAddress1').val(),
        Address2: $('#txtAddress2').val(),
        Longitude: $('#txtLongitude').val(),
        Latitude: $('#txtLatitude').val(),
        City: $('#txtCity').val(),
        State: $('#txtState').val(),
        Pin: $('#txtPin').val(),
        Country: $('#txtCountry').val(),
       // Descriptions: $('#txtDescriptions').val()
            }
    $.ajax({
        url: '/Location/UpdateLocation',
        type: 'POST',
        data: objdata,
        dataType: "json",
        crossDomain: true,
        contentType: "application/x-www-form-urlencoded",

        success: function () {
            debugger;
            alert('Record Updated');
            ShowCompanyData();

        },
        error: function () {
            debugger;
            alert('Data not save');
        }
    })
}
//*****Add data 
//function AddLocation() {
//    debugger;
//    $('#ContactId').css('display', 'block');
//    // $('#lblCompanyId').css('display', 'block');
//    $('#btnUpdate1').css('display', 'none');
//    debugger;
//    var objdata = {
//        ContactPersonName: $('#txtContactPersonName').val(),
//        ContactPersonNumber: $('#txtContactPersonNumber').val(),
//        Address1: $('#txtAddress1').val(),
//        Address2: $('#txtAddress2').val(),
//        Longitude: $('#txtLongitude').val(),
//        Latitude: $('#txtLatitude').val(),
//        City: $('#txtCity').val(),
//        State: $('#txtState').val(),
//        Pin: $('#txtPin').val(),
//        Country: $('#txtCountry').val(),
//       // Descriptions: $('#txtDescriptions').val(),
//    }
//    $.ajax({
//        url: 'Location/AddLocation',
//        type: 'POST',
//        data: objdata,
//        dataType: "json",
//        crossDomain: true,
//        contentType: "application/x-www-form-urlencoded",
//        success: function () {
//            alert('Location data Saved');
//            ShowCompanyData();
//        },
//        error: function () {
//            alert('Data not save');
//        }
//    })
//    //*****edit****

    function Edit(contactId) {
        debugger;
        $.ajax({
            url: '/Location/Edit?ContactId=' + contactId,
            type: 'get',
            contentType: 'application/json;charset=utf-8;',
            dataType: 'json',
            success: function (response) {
                 //$('#CompanyModal').modal('show');
                $('#txtContactId').val(response.contactId);
                $('#txtContactPersonName').val(response.contactPersonName);
                $('#txtContactPersonNumber').val(response.contactPersonNumber);
                $('#txtAddress1').val(response.address1);
                $('#txtAddress2').val(response.address2);
                $('#txtLongitude').val(response.longitude);
                $('#txtLatitude').val(response.latitude);
                $('#txtCity').val(response.city);
                $('#txtState').val(response.state);
                $('#txtPin').val(response.pin);
                $('#txtCountry').val(response.country);
                $('#txtDescriptions').val(response.descriptions);
                $('#btnAdd1').css('display', 'none');
                $('#btnUpdate1').css('display', 'block')
            },
            error: function () {
                alert('data not found');
            }
        })
    };
