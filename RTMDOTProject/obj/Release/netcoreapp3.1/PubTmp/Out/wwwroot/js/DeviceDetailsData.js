
$(document).ready(function () {
    ShowDeviceDetail();
    // ************Email Modal End***************
});
//PDF Export
function PDFExport() {

    html2canvas($('#tlbDataTable')[0], {
        onrendered: function (canvas) {
            var data = canvas.toDataURL();
            var docDefinition = {
                content: [{
                    image: data,
                    width: 500
                }]
            };
            pdfMake.createPdf(docDefinition).download("Device-details.pdf");
        }
    });

}
// Company Details
function ShowDeviceDetail() {
    $("#searchrec").on("keyup", function () {

        var value = $(this).val().toLowerCase();

        $("#tdata tr").filter(function () {

            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
    $.ajax({
        url: '/DeviceDetail/GetDeviceDetails',
        type: 'get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result, status, xhr) {

            var object = '';
            $.each(JSON.parse(result), function (index, item) {

                object += '<tr>';
                object += '<td> <button onclick="Edit(' + item.DeviceId + ');"><i class="fa fa-pencil" style="border:none;"></i></button>  </td>';

                object += '<td>' + item.IEMINumber + '</td>';
                object += '<td>' + item.DeviceType + '</td>';
                object += '<td>' + item.DeviceName + '</td>';
                object += '<td>' + item.Status + '</td>';
                object += '<td>' + item.Description + '</td>';


                object += '</tr>';
            })

            $('#tdata').html(object);
        },
        error: function () {

            alert("data can't get");
        }
    });
};

