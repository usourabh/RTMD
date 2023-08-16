a = 1;
$(document).ready(function () {
    ShowRDData();
    ShowSurveyData();
    $('#example').show();  
});

function ShowRDData() {
    $.ajax({
        url: "/Master/GetRDDetail",
        type: 'get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (strresult) {
            debugger
            var result = JSON.parse(strresult);
            var object = '';
            $.each(result, function (index, item) {
               // object += '<tr>';
               // object += '<td>' + (index + 1)+'</td>';
               // object += '<td>' + item.RDCode + '</td>';
               // object += '<td>' + item.RDName + '</td>';
               //// //object += '<td>' + item.RDType + '</td>';
               // object += '<td>' + item.BranchName + '</td>';
               // object += '<td>' + item.RegionName + '</td>';
               // object += '<td>' + item.ASMArea + '</td>';                
               // object += '<td>' + item.SOTerritory + '</td>';
               // object += '<td>' + item.Town + '</td>';
               // object += '<td>' + item.State + '</td>';
               // object += '<td>' + item.Address + '</td>';
               // object += '<td>' + item.Phone + '</td>';
               // object += '<td>' + item.ContactPerson + '</td>';               
               // object += '<td>' + item.MobileNo + '</td>';
               // object += '<td>' + item.EmailId + '</td>';
                ////object += '<td>' + item.Description + '</td>';
  
                object += '<tr>';
                object += '<td>' + (index + 1) + '</td>';
                object += '<td>' + item.Image + '</td>';
                object += '<td>' + item.RDCode + '</td>';
                object += '<td>' + item.RDName + '</td>';
                object += '<td>' + item.Address + '</td>';
                object += '<td>' + item.IEMINumber + '</td>';
                object += '<td>' + item.visicooler + '</td>';
                object += '<td>' + item.Qrcode + '</td>';
                object += '<td>' + item.Phone + '</td>';

              
              
                if (item.IsActive = 1)
                {
                    object += '<td>Active</td>';
                }
                else
                {
                    object += '<td>InActive</td>';
                }
                object += '<td> <button class="btn btn-primary" onclick="Edit(' + item.Id + ')"><i class="fa fa-pen"></i></button> &nbsp;<button class="btn btn-danger" onclick="Delete(' + item.Id + ')"><i class="fa fa-trash"></i></button> </td>';
                object += '</tr>';
            })                                              
            $('#example > tbody').html(object);
                        $('#example').dataTable({
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

function ShowSurveyData() {
    $.ajax({
        url: "/Master/GetSurveyDetail",
        type: 'get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (strresult) {
            debugger             
            var result = JSON.parse(strresult);
            var object = '';
            $.each(result, function (index, item) {
                object += '<tr>';
                object += '<td>' + (index + 1) + '</td>';
                object += '<td>' + item.DeviceCode + '</td>';          
                object += '<td>' + item.RDCode + '</td>';          
                object += '<td>' + item.Lat + '</td>';
                object += '<td>' + item.Lng + '</td>';
                object += '<td>' + item.ApprovedBy + '</td>';
                object += '<td>' + item.ApprovedPersonMobileNo + '</td>';
                object += '<td>' + item.Img1 + '</td>';
                object += '<td>' + item.Img2 + '</td>';
                object += '<td>' + item.Img3 + '</td>';
                object += '<td>' + item.Remark + '</td>';
              
                object += '</tr>';
            })
            $('#Surveyexample > tbody').html(object);
            $('#Surveyexample').dataTable({
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
//to add Device record

function AddRD() {
    var fbStatus;
    if ($("#txtStatus").is(':checked')) {
        fbStatus = true;
    }
    else {
        fbStatus = false;
    }

    var objdata = {
        Id: $('#txtId').val(),
        RDCode: $('#txtRDCode').val(),
        RDName: $('#txtRDName').val(),
        RegionName: $('#txtRegion').val(),
        BranchName: $('#txtBranch').val(),
        ASMArea: $('#txtasmarea').val(),
        SOTerritory: $('#txtsoterritory').val(),
        Town: $('#txtTown').val(),
        State: $('#txtstate').val(),
        Address: $('#txtaddress').val(),
        Phone: $('#txtphone1').val(),
        ContactPerson: $('#txtcontactperson').val(),
        MobileNo: $('#txtphone2').val(),
        EmailId: $('#txtemail').val(),
        IsActive: fbStatus,
        Description: $('#txtDescription').val(),
    }
    debugger;
    $.ajax({
        url: '/Master/AddRDDetails',
        type: 'POST',
        data: objdata,
        dataType: "json",
        crossDomain: true,
        contentType: "application/x-www-form-urlencoded",
        success: function () {
            ShowRDData();
            $('#SaleModal').modal('hide');

        },
        error: function () {
            alert('Data not save');
        }
    })
}

//(***update****)
function UpdateRDData() {
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
        Id: $('#txtId').val(),
        RDCode: $('#txtRDCode').val(),
        RDName: $('#txtRDName').val(),
        RegionName: $('#txtRegion').val(),
        BranchName: $('#txtBranch').val(),
        ASMArea: $('#txtasmarea').val(),
        SOTerritory: $('#txtsoterritory').val(),
        Town: $('#txtTown').val(),
        State: $('#txtstate').val(),
        Address: $('#txtaddress').val(),
        Phone: $('#txtphone1').val(),
        ContactPerson: $('#txtcontactperson').val(),
        MobileNo: $('#txtphone2').val(),
        EmailId: $('#txtemail').val(),
        IsActive: fbStatus,
        Description: $('#txtDescription').val(),
    }
    $.ajax({
        url: '/Master/UpdateData',
        type: 'POST',
        data: objdata,
        dataType: "json",
        crossDomain: true,
        contentType: "application/x-www-form-urlencoded",
        success: function () {
            ShowRDData();
        },
        error: function () {
            debugger;
            alert('Data not save');
        }
    })
}


//delete device records
function Delete(Id) {
    $.ajax({
        url: '/Master/Deletedata?Id=' + Id,
        type: 'get',
        contentType: 'application/json;charset=utf-8;',
        dataType: 'json',
        success: function (response) {
            alert('Record  Deleted');
            ShowRDData();
        },
        error: function () {
            alert('data not found');
        }
    })
};


//edit existing records
function Edit(Id) {
    $("#SaleModal").modal('show');
    $.ajax({
        url: '/Master/Editdata?Id=' + Id,
        type: 'get',
        contentType: 'application/json;charset=utf-8;',
        dataType: 'json',
        success: function (response) {
            debugger
            $('#SaleModal').modal('show');
            Id: $('#txtId').val(response.Id);
            RDCode: $('#txtRDCode').val(response.Rdcode);
            RDName: $('#txtRDName').val(response.Rdname);
            RegionName: $('#txtRegion').val(response.RegionName);
            BranchName: $('#txtBranch').val(response.BranchName);
            ASMArea: $('#txtasmarea').val(response.Asmarea);
            SOTerritory: $('#txtsoterritory').val(response.Soterritory);
            Town: $('#txtTown').val(response.Town);
            State: $('#txtstate').val(response.State);
            Address: $('#txtaddress').val(response.Address);
            Phone: $('#txtphone').val(response.Phone);
            ContactPerson: $('#txtcontactperson').val(response.ContactPerson);
            MobileNo: $('#txtphone').val(response.MobileNo);
            EmailId: $('#txtemail').val(response.EmailId);
            IsActive: $('#txtStatus').val(response.IsActive);
            Description: $('#txtDescription').val(response.Description);
            $('#btnAdd').css('display', 'none');
            $('#btnUpdate').css('display', 'block');
            $('#SaleModal').modal('show');
        },
        error: function () {
            alert('data not found');
        }
    })
};

