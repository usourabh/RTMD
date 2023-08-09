$(document).ready(function () {
    ShowQRDetailsData();

    //let id = getUrlParameterInfo('id');
    //console.log("id :- ", id);

    //if (id !== '') {
    //    setQRData(id);
    //}

});

function ShowQRDetailsData() {
    debugger;
    $.ajax({
        url: "/QR/GetQRDetails",
        type: 'get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (strresult) {
            var result = JSON.parse(strresult);
            var object = '';
            $.each(result, function (index, item) {
                object += '<tr >';
                object += '<td>' + (index + 1) + '<a target="_blank" href="/Qr/CreateQRCode?id=' + item.QRId + '"><i  class="fa fa-qrcode"></i></a></td>';
                object += '<td>' + item.QRId + '</td>';
                object += '<td>' + item.TextHeader + '</td>';
                object += '<td>' + item.TextBody + '</td>';
                object += '<td>' + item.ImageUrl + '</td>';
                object += '<td>' + (item.IsActive ==true?"Active":"In-Active") + '</td>';
                // object += '<td><button class="btn btn-primary"onclick="Edit(' + item.Id + ')"><i class="fa fa-pen"></i></button></td>';
                // object += '<td><button class="btn btn-primary"onclick="Edit(' + item.Id + ')"><i class="fa fa-pen"></i></button><a onclick="ShowQrDetail(' + item.QRId + ')"  href="/QR/app?id=' + item.QRId + '" >Detail</a></td>';

                object += '<td><button class="btn btn-primary"onclick="Edit(' + item.Id + ')"><i  class="fa fa-pen"></i></button> <a target="_blank" href="/Qr/app?id=' + item.QRId + '" style="border:none; background:none; color:blue;">View Page</a></td>';
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

function AddQR() {
    $('#btnAdd').show();

    var fbStatus;
    debugger;
    if ($("#txtIsActive").is(':checked')) {
        fbStatus = true;
    }
    else {
        fbStatus = false;
    }
    var objdata = {
        Id: $('#txtQRId').val(),
        Qrid: $('#txtQRCode').val(),
        TextHeader: $('#txtTextHeader').val(),
        TextBody: $('#txtTextBody').val(),
        ImageUrl: $('#txtImageURL').val(),
        IsActive: fbStatus,
        // CreatedBy: 'Ajeevi',
        //// CreatedOn: '2023-03-01's,
        // ModifiedBy: 'ritu'
        //  ModifiedOn:'2023-03-01',
    }
    debugger;
    $.ajax({
        url: '/QR/AddQR',
        type: 'POST',
        data: objdata,
        dataType: "json",
        crossDomain: true,
        contentType: "application/x-www-form-urlencoded",
        success: function (data) {
            //    alert('data Save');
            $('#SaleModal').modal('hide');
            ShowQRDetailsData();
        },
        error: function () {
            alert('Data not save');
        }
    })
}


function Edit(Id) {
    //   alert("edit device");
    $("#SaleModal").modal('show');
    $('#btnAdd').hide();
    $('#btnUpdate').show();
    //  debugger;
    $.ajax({
        url: '/QR/Edit?Id=' + Id,
        type: 'get',
        contentType: 'application/json;charset=utf-8;',
        dataType: 'json',
        success: function (response) {
            debugger;
            $('#SaleModal').modal('show');
            $('#txtQRId').val(response.Id);
            $('#txtQRCode').val(response.Qrid);
            $('#txtTextHeader').val(response.TextHeader);
            $('#txtTextBody').val(response.TextBody);
            $('#txtImageURL').val(response.ImageUrl);
            $('#txtIsActive').val(response.IsActive);

            $('#SaleModal').modal('show');
        },
        error: function () {
            alert('data not found');
        }
    })
};

function UpdateQR() {
    var isvalid = 1;
    if ($("#txtIsActive").is(':checked')) {
        fbStatus = true;
    }
    else {
        fbStatus = false;
    }



    var IFormData = {
        Id: $('#txtQRId').val(),
        Qrid: $('#txtQRCode').val(),
        TextHeader: $('#txtTextHeader').val(),
        TextBody: $('#txtTextBody').val(),
        ImageUrl: $('#txtImageURL').val(),
        IsActive: fbStatus
    };

    var formData = new FormData();
    formData.append('file', $('#txtImageURL')[0].files[0]);
    formData.append('input', JSON.stringify(IFormData));
    
    if (isvalid == 1) {
        $.ajax({
            type: "POST",
            url: '/QR/QRUpdate',
            data: formData,
            contentType: false,
            processData: false,
            success: function (data) {
                ShowCustomMessage('1', data, '/Qr/Index');
                $('#SaleModal').modal('toggle');
            },
            error: function (result) {
                ShowCustomMessage('0', 'Something Went Wrong!', '');
            }
        });
    }
    else
        ShowCustomMessage('0', 'Please Enter All Required Details', '');

}



//function ShowQrDetail(QrId) {
//    debugger
//    $.ajax({
//        url: '/QR/QRDetailByQrid?QrId=' + QrId,
//        type: 'POST',
//        dataType: 'json',
//        success: function (result) {
//            var Fresult = JSON.parse(result);
//            debugger
//            $.each(Fresult, function (index, item) {
//                object += '<tr >';
//                object += '<td>' + item.TextHeader + '</td>';
//                object += '<td>' + item.TextBody + '</td>';
//                object += '<td>' + item.ImageUrl + '</td>';
//                object += '</tr>';
//                $('#THead').html(item.TextHeader);
//                $('#tbody').html(item.TextBody);

//            });
//        },
//        error: function () {
//        }
//    });
//};


//function getUrlParameterInfo(name) {
//    name = name.replace(/[\[]/, '\\[').replace(/[\]]/, '\\]');
//    var regex = new RegExp('[\\?&]' + name + '=([^&#]*)');
//    var results = regex.exec(location.search);
//    return results === null ? '' : decodeURIComponent(results[1].replace(/\+/g, ' '));
//};

function ShowQRData(Id) {
    window.location.href = "/QR/app?Id=" + Id;
}

//function setQRData(QrId) {

//    $.ajax({
//        url: '/QR/QRDetailByQrid?QrId=' + QrId,
//        type: 'GET',
//        contentType: 'application/json;charset=utf-8',
//        dataType: 'json',

//        success: function (response) {
//            console.log('response', response);
//            $('#THead').val(response.TextHeader);
//            $('#tbody').val(response.TextBody);
//        },
//        error: function () {
//            alert('data not found');
//        }
//    })

//}

