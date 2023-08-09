$(document).ready(function () {
    ShowDeviceTransactionData();
    debugger;
});

function ShowDeviceTransactionData() {
    debugger;
    $.ajax({
        url: "/DeviceTransaction/TempById",
        type: 'POST',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result) {
            debugger;
           
          //  var object = '';         
            $.each(result, function (index, item) {
                
                    //object += '{';
                    //object += 'day:' + item.datedOn + ',';
                    //object += 'oranges:' + item.temp + ',';
                    //object += '},';      
            })
            const dataSource = result;
          
           // alert(dataSource);
            $(() => {
                $('#chart').dxChart({
                    dataSource,
                    series: {
                        argumentField: 'datedOn',
                        valueField: 'temp',
                        name: 'Devices',
                        type: 'bar',
                        color: '#ffaa66',
                    },
                });
            });
        },
        error: function () {
            alert("data can't get");
        }
    });
};