$(document).ready(function () {
	SetDashboardCount();
});

function SetDashboardCount() {
    $.ajax({
        url: '/Dashboard/DashboardNotification',
        type: 'POST',
        dataType: 'json',
        success: function (result) {
            var data = JSON.parse(result);

            $('#pTotalDevice').text(data.TotalDevice);
            $('#pInActiveDevice').text(data.TotalINActiveDevice);
            $('#pActiveDevice').text(data.TotalActiveDevice);
            $('#pTotalAlerts').text(data.TotalAlert);
        },
        error: function () {
        }
    });
};

function ShowGraf() {
    $.ajax({
        url: "/DeviceTransaction/GetChartData",
        type: 'POST',
        data: { imei: "" },
        success: function (jsdata) {
            var d1 = [];
            var d2 = [];
            var d3 = [];
            for (var i = 0; i < jsdata.length; i++) {
                var Item = jsdata[i];

                d1.push({ x: new Date(Item.yy, Item.mm, Item.dd), y: Item.Tmax });
                d2.push({ x: new Date(Item.yy, Item.mm, Item.dd), y: Item.Tavg });
                d3.push({ x: new Date(Item.yy, Item.mm, Item.dd), y: Item.TMin });


            }

            var options = {
                animationEnabled: true,
                theme: "light2",
                title: {
                    text: "LAST 7 DAYS MONITORING-ALL DEVICES"
                },
                axisX: {
                },
                axisY: {
                    prefix: "℃ ",
                    labelFormatter: addSymbols
                },
                toolTip: {
                    shared: true
                },
                legend: {
                    cursor: "pointer",
                    itemclick: toggleDataSeries
                },
                data: [
                    {
                        type: "column",
                        name: "Maximum Temp",
                        showInLegend: true,
                        dataPoints: d1
                    },
                    {
                        type: "line",
                        name: "Average Temp",
                        showInLegend: true,
                        dataPoints: d2
                    },
                    {
                        type: "area",
                        name: "Low Temp",
                        markerBorderColor: "white",
                        markerBorderThickness: 2,
                        showInLegend: true,
                        dataPoints: d3
                    }]
            };

            $("#chartContainer").CanvasJSChart(options);

            function addSymbols(e) {
                var suffixes = ["", "K", "M", "B"];
                var order = Math.max(Math.floor(Math.log(e.value) / Math.log(1000)), 0);

                if (order > suffixes.length - 1)
                    order = suffixes.length - 1;

                var suffix = suffixes[order];
                return CanvasJS.formatNumber(e.value / Math.pow(1000, order)) + suffix;
            }

            function toggleDataSeries(e) {
                if (typeof (e.dataSeries.visible) === "undefined" || e.dataSeries.visible) {
                    e.dataSeries.visible = false;
                } else {
                    e.dataSeries.visible = true;
                }
                e.chart.render();
            }
        },
        error: function (xhr, status, error) {
            alert("Result: " + status + " " + error + " " + xhr.status + " " + xhr.statusText)
        }
    });

}



