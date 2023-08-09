$(document).ready(function () {  
    ShowInActiveDeviceData();
   
});



function ShowInActiveDeviceData() {

    $.ajax({
        url: '/Dashboard/GetInActiveDeviceDetail',
        type: 'get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (JData, status, xhr) {
            var result = JSON.parse(JData);
            var object = '';
            $.each(result, function (index, item) {
                object += '<tr>';                
                object += '<td>' +(index+1) + '</td>';
                object += '<td>' + item.RDName + '</td>';
                object += '<td>' + item.ContactPerson + '</td>';
                object += '<td>' + item.Phone + '</td>';
                object += '<td>' + item.IEMINumber + '</td>';
                if (parseFloat(item.Temp) > 22 || parseFloat(item.Temp) < 18) {
                    object += '<td style="color:red;"class="blink" ><marquee direction ="up"width="100%" behavior="alternate" scrollamount="2" scrolldelay=".1">' + item.Temp + '</marquee></td>';
                }
                else {
                    object += '<td style="color:black;">' + item.Temp + '</td>';
                }
                object += '<td>' + item.DeviceType + '</td>';
                object += '<td>' + item.EmailId + '</td>';
                object += '<td>' + item.DatedOn + '</td>';          
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

