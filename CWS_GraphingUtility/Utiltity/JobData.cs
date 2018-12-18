using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWS_GraphingUtility.Utiltity
{
    [Serializable]
   public class JobData
    {

        #region Fields

        /// <summary>
        /// List of <see cref="StageData"/> objects.
        /// </summary>
        //List<StageData> stages;
        Dictionary<int, StageData> stages;

        /// <summary>
        /// List of <see cref="StageData"/> objects to serve as a backup.
        /// </summary>
        Dictionary<int, StageData> stagesBackup;

        /// <summary>
        /// String representation of the job title.
        /// </summary>
        private string jobTitle;

        /// <summary>
        /// String representation of the field.
        /// </summary>
        private string field;

        /// <summary>
        /// String representation of the well.
        /// </summary>
        private string well;


        #endregion

        #region Properties

        public DateTime JobDate
        {
            get; set;
        }


        public int NumberOfStages
        {
            get
            {
                return stages.Count;
            }
        }

        public int[] StageNumbers
        {
            get
            {
                return stages.Keys.ToArray();
            }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new instance of the <see cref="JobData"/> class.
        /// </summary>
        /// <param name="jobName">The name of the job.</param>
        public JobData(string filePath, DateTime dt) {

            stages = new Dictionary<int,StageData>();
            JobDate = dt;
            ParseJobData(filePath);

            if(stages.Count > 0)
            {
                stagesBackup = new Dictionary<int, StageData>(stages);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the JSON Object from the json file.
        /// </summary>
        /// <param name="filePath">The string representation of the filepath.</param>
        private void ParseJobData(string filePath)
        {
            using (StreamReader reader = File.OpenText(filePath)) {
                Newtonsoft.Json.Linq.JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(reader));

                string jobName = (string)o["name"];
                string field = (string)o["field"];
                string well = (string)o["well"];

                JArray stges = (JArray)o["stages"];

                foreach (var stage in stges)
                {
                    int number = (int)stage["number"];
                    double barrels = (double)stage["barrels"];
                    JArray durationData = (JArray)stage["duration_data"];
                    JArray pressureData = (JArray)stage["pressure_data"];
                    JArray waterData = (JArray)stage["water_rate_data"];
                    JArray sandData = (JArray)stage["sand_rate_data"];

                    List<double> dList = new List<double>(ParseToDoubleList(durationData));
                    List<double> pList = new List<double>(ParseToDoubleList(pressureData));
                    List<double> wList = new List<double>(ParseToDoubleList(waterData));
                    List<double> sList = new List<double>(ParseToDoubleList(sandData));
                    StageData sd = new StageData(JobDate,number, pList, wList, sList, dList);
                    stages.Add(number,sd);
                }

            }
        }

        /// <summary>
        /// Takes a JArray object and returns a <see cref="List{T}"/>.
        /// </summary>
        /// <param name="list">The JArray being converted.</param>
        /// <returns>A list of doubles.</returns>
        private List<double> ParseToDoubleList(JArray list)
        {
            List<double> outList = new List<double>();

            foreach(var obj in list)
            {
                if(obj != null && obj.GetType() != null && !obj.Equals("\"\""))
                {
                    try
                    {
                        double newDouble = double.Parse(obj.ToString());
                        outList.Add(newDouble);
                    } 
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
            }

            return outList;
        }

        /// <summary>
        /// Gets a specified stage number from the stage dictionary list..
        /// </summary>
        /// <param name="stage">The stage to get.</param>
        /// <returns></returns>
        public StageData GetDetailsForStage(int stage)
        {
            if(stages.ContainsKey(stage))
            {
                return stages[stage];
            }
            return null;
        }

        public int GetFirstStageNumber()
        {
            return stages.Keys.First<int>();
        }

        public void DeleteStage(int stage)
        {
            if(stages.ContainsKey(stage))
            {
                stages.Remove(stage);
            }
        }

        public void UndoAllChanges()
        {
            stages = new Dictionary<int, StageData>(stagesBackup);
        }

        #endregion

    }
}
