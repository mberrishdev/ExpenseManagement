import ChartBar from "./ChartBar";
import "./Chart.css";

const Chart = (props) => {
  const dataPointValues = props.dataPoints.map((dataPoint) => dataPoint.value);
  const totalMaximum = Math.max(...dataPointValues);

  return (
    <div className="chart">
      {props.dataPoints.map((dataPoint) => (
        <ChartBar
          key={dataPoint.lables}
          value={dataPoint.value}
          maxValue={totalMaximum}
          label={dataPoint.lable}
        />
      ))}
    </div>
  );
};
export default Chart;
