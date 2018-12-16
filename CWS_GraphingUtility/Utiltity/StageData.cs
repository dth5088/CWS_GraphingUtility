using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace CWS_GraphingUtility.Utiltity
{
    /// <summary>
    /// This class represents the data collected for one entire
    /// stage. A stage is a specified depth in the ground.
    /// </summary>
    [Serializable]
    public class StageData {

        #region Fields

        /// <summary>
        /// List to hold the pressure data.
        /// </summary>
        private Dictionary<DateTime, double> pressureData;

        /// <summary>
        /// List to hold the water rate data.
        /// </summary>
        private Dictionary<DateTime, double> waterData;

        /// <summary>
        /// List to hold the sand rate data.
        /// </summary>
        private Dictionary<DateTime, double> sandData;

        /// <summary>
        /// Represents the stage number.
        /// </summary>
        private int stageNumber;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets a reference to the JobDate.
        /// </summary>
        public DateTime JobDate { get; set; }

        /// <summary>
        /// Gets a dictionary list of PressureSeriesData.
        /// </summary>
        public Dictionary<DateTime,double> PressureSeriesData {

            get { return pressureData; }
        }

        /// <summary>
        /// Gets a dictionary list of WaterSeriesData.
        /// </summary>
        public Dictionary<DateTime,double> WaterSeriesData
        {
            get
            {
                return waterData;
            }
        }

        /// <summary>
        /// Gets a dictionary list of SandSeriesData.
        /// </summary>
        public Dictionary<DateTime,double> SandSeriesData
        {
            get
            {
                return sandData;
            }
        }

        /// <summary>
        /// Gets the stage number.
        /// </summary>
        public int StageNumber
        {
            get
            {
                return stageNumber;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructs a new instance of the <see cref="StageData"/> object.
        /// </summary>
        /// <param name="jd">The Job Date.</param>
        /// <param name="number">The stage number.</param>
        /// <param name="pressure">An array of pressure data points.</param>
        /// <param name="water">An array of water rate data points.</param>
        /// <param name="sand">An array of sand rate data points.</param>
        /// <param name="duration">An array of duration data points.</param>
        public StageData(DateTime jd, int number, List<double> pressure, List<double> water, List<double> sand, List<double> duration) {

            stageNumber = number;
            pressureData = new Dictionary<DateTime, double>();
            waterData = new Dictionary<DateTime, double>();
            sandData = new Dictionary<DateTime, double>();

            if (jd == null)
            {
                JobDate = DateTime.Now;
            }
            else
            {
                JobDate = jd;
            }

            CreateStageCollections(pressure, water, sand, duration);
        }


        #endregion

        #region Methods

        private void CreateStageCollections(List<double> pressure, List<double> water, List<double> sand, List<double> duration) {

            bool matchSize = pressure.Count == water.Count && pressure.Count == sand.Count && pressure.Count == duration.Count;

            if (!matchSize) return;

            for(int i = 0; i < pressure.Count; i++)
            {
                DateTime plotTime = JobDate.AddMilliseconds(duration[i]);
                if(pressureData.ContainsKey(plotTime))
                {
                    var average = (pressureData[plotTime] + pressure[i]) / 2;
                    pressureData[plotTime] = average;
                }
                else
                {
                    pressureData.Add(plotTime, pressure[i]);
                }

                if(waterData.ContainsKey(plotTime))
                {
                    var average = (waterData[plotTime] + water[i]) / 2;
                    waterData[plotTime] = average;
                }
                else
                {
                    waterData.Add(plotTime, water[i]);
                }

                if(sandData.ContainsKey(plotTime))
                {
                    var average = (sandData[plotTime] + sand[i]) / 2;
                    sandData[plotTime] = average;
                }
                else
                {
                    sandData.Add(plotTime, sand[i]);
                }
                JobDate = plotTime;
            }
            
        }

        /// <summary>
        /// Deletes all of the items in the pressureData list that fall
        /// within the start and end times passed.
        /// </summary>
        /// <param name="start">The first time to delete.</param>
        /// <param name="end">The last time to delete.</param>
        private void DeletePressurFromTo(DateTime start, DateTime end)
        {
            var temp = pressureData;
            foreach (var obj in temp)
            {
                if(obj.Key.CompareTo(start) >= 0 && obj.Key.CompareTo(end) < 0)
                {
                    pressureData.Remove(obj.Key);
                }
            }
        }

        /// <summary>
        /// Deletes all of the items in the pressureData list that fall
        /// within the start and end times passed.
        /// </summary>
        /// <param name="start">The first time to delete.</param>
        /// <param name="end">The last time to delete.</param>
        private void DeleteWaterFromTo(DateTime start, DateTime end)
        {
            var temp = waterData;
            foreach (var obj in temp)
            {
                if (obj.Key.CompareTo(start) >= 0 && obj.Key.CompareTo(end) < 0)
                {
                    pressureData.Remove(obj.Key);
                }
            }
        }

        /// <summary>
        /// Deletes all of the items in the pressureData list that fall
        /// within the start and end times passed.
        /// </summary>
        /// <param name="start">The first time to delete.</param>
        /// <param name="end">The last time to delete.</param>
        private void DeleteSandFromTo(DateTime start, DateTime end)
        {
            var temp = sandData;
            foreach (var obj in temp)
            {
                if (obj.Key.CompareTo(start) >= 0 && obj.Key.CompareTo(end) < 0)
                {
                    pressureData.Remove(obj.Key);
                }
            }
        }

        public void FillPressureSeries(Series series)
        {
            foreach( var obj in PressureSeriesData)
            {
                DateTime t = obj.Key;
                double p = obj.Value;
                series.Points.AddXY(t.ToString("HH:mm:ss"), p);
            }
            
        }

        public void FillWaterSeries(Series series)
        {
            foreach (var obj in WaterSeriesData)
            {
                DateTime t = obj.Key;
                double p = obj.Value;
                series.Points.AddXY(t.ToString("HH:mm:ss"), p);
            }
        }

        public void FillSandSeries(Series series)
        {
            foreach (var obj in SandSeriesData)
            {
                DateTime t = obj.Key;
                double p = obj.Value;
                series.Points.AddXY(t.ToString("HH:mm:ss"), p);
            }
        }
        #endregion


    }
}
