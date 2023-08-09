$(() => {
    debugger;
  const chart = $('#chart').dxChart({
    dataSource: population,
    series: [{
      argumentField: 'day',
    }],
    argumentAxis: {
      label: {
        wordWrap: 'none',
        overlappingBehavior: overlappingModes[0],
      },
    },
    legend: {
      visible: false,
    },
    title: 'Weekly Temperature',
  }).dxChart('instance');
    debugger;
  $('#overlapping-modes').dxSelectBox({
    dataSource: overlappingModes,
    value: overlappingModes[0],
    onValueChanged(e) {
      chart.option('argumentAxis.label.overlappingBehavior', e.value);
    },
  });
});
const overlappingModes = ['stagger', 'rotate', 'hide', 'none'];
const population = [
    { day: 'Sunday', val: 13.82 },
    { day: 'Monday', val: 13.14 },
    { day: 'Tuesday', val: 32.47 },
    { day: 'Wednesday', val: 26.16 },
    { day: 'Thursday', val: 20.70 },
    { day: 'Friday', val: 19.68 },
    { day: 'Saturday', val: 18.85 },
];