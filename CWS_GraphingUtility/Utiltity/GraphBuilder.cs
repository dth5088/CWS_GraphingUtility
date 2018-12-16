using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.WinForms;
using LiveCharts.Wpf;


namespace CWS_GraphingUtility
{
    public class GraphBuilder
    {
        #region Fields

        #endregion

        #region Constructor

        public GraphBuilder()
        {

        }

        #endregion


        public static LiveCharts.WinForms.CartesianChart CreateGraph(int stageNumber, Dictionary<DateTime, double> PressureSeriesData, Dictionary<DateTime, double> WaterSeriesData, Dictionary<DateTime, double> SandSeriesData)
        {

            List<string> labels = new List<string>(PressureSeriesData.Keys.Select(date => date.ToString("HH:mm:ss")).ToList<string>());


            LiveCharts.WinForms.CartesianChart chart = new LiveCharts.WinForms.CartesianChart();

            chart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Pressure",
                    Values = new ChartValues<double>(PressureSeriesData.Values),
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 15,
                    PointForeground = Brushes.Gray
                },
                new LineSeries
                {
                    Title = "Water Rate",
                    Values = new ChartValues<double>(WaterSeriesData.Values)
                },
                new LineSeries
                {
                    Title = "Sand Rate",
                    Values = new ChartValues<double>(SandSeriesData.Values)
                }
            };

            chart.AxisX.Add(new Axis
            {
                Title = "Time",
                Labels = labels
            });
            chart.LegendLocation = LegendLocation.Right;

            chart.DataClick += CartesianChartOnDataClick;

            return chart;
        }

        private static void CartesianChartOnDataClick(object sender, ChartPoint chartPoint)
        {
            MessageBox.Show("You clicked (" + chartPoint.X + ", " + chartPoint.Y + ")");
        }


    }
}
