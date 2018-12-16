﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CWS_GraphingUtility.Utiltity;

namespace CWS_GraphingUtility.GUI.Controls
{
    [Serializable]
    public enum Mode
    {
        Edit,
        View

    }

    [Serializable]
    public enum WhichLine
    {
        Pressure,

        Water,

        Sand
    }

    [Serializable]
    public enum WhichValue
    {
        MinPressure,

        MaxPressure,

        MinWater,

        MaxWater,

        MinSand,

        MaxSand
    }

    public partial class GraphSelecterDisplayPanel : UserControl
    {
        #region Fields

        /// <summary>
        /// Indicates what stage number is currently being displayed.
        /// </summary>
        private int stageNumber;

        /// <summary>
        /// Indicates what the current mode is.
        /// </summary>
        private Mode currentMode;

        /// <summary>
        /// Indicates how many stages in total there are.
        /// </summary>
        private int totalNumberOfStages;

        private MenuItem editMode;

        private MenuItem viewMode;

        private ContextMenu contextMenu;


        #endregion

        #region Properties

        public event ModeChangeHandler ChangeMode;

        public delegate void ModeChangeHandler(object o, ModeChangeEventArgs e);


        /// <summary>
        /// Gets or sets a reference to the stage number.
        /// </summary>
        public int StageNumber
        {
            get
            {
                stageNumber = int.Parse(stageNumberLabel.Text);

                return stageNumber;
            }

            set
            {
                if (stageNumber != value)
                {
                    stageNumber = value;
                    stageNumberLabel.Text = stageNumber.ToString();
                }
            }
        }

        /// <summary>
        /// Gets or sets the stage data.
        /// </summary>
        public StageData StageData { get; set; }

        /// <summary>
        /// Gets or sets the number of total stages for the current job.
        /// </summary>
        public int TotalStages {
            get
            {
                return totalNumberOfStages;
            }
               

            set {
                totalNumberOfStages = value;
                totalStagesLabel.Text = value.ToString();
            }
        }

        #endregion

        #region Constructor

        public GraphSelecterDisplayPanel()
        {
            InitializeComponent();

            currentMode = Mode.View;

            CreateContextMenu();

        }

        #endregion

        #region Methods

        #region Public

        /// <summary>
        /// Assign the default values read from the Resource File.
        /// </summary>
        /// <param name="pMin">Minimum Pressure value for the scale.</param>
        /// <param name="pMax">Maximum Pressure value for the scale.</param>
        /// <param name="rMin">Minimum Rate value for the scale.</param>
        /// <param name="rMax">Maximum Rate value for the scale.</param>
        /// <param name="pC">Pressure Line Color.</param>
        /// <param name="wC">Water Line Color.</param>
        /// <param name="sC">Sand Line Color.</param>
        public void AssignChartConfig(double pMin, double pMax, double rMin, double rMax, Color pC, Color wC, Color sC)
        {
            // set the min/max rate (for sand and water).
            displayedChart.ChartAreas[0].AxisY2.Minimum = rMin;
            displayedChart.ChartAreas[0].AxisY2.Maximum = rMax;

            // set the min/max pressure.
            displayedChart.ChartAreas[0].AxisY.Minimum = pMin;
            displayedChart.ChartAreas[0].AxisY.Maximum = pMax;

            // set pressure line color
            displayedChart.Series["Pressure"].Color = pC;

            // set water line color
            displayedChart.Series["Water"].Color = wC;

            // set sand line color
            displayedChart.Series["Sand"].Color = sC;
        }

        public void UpdateChartScaleValues(AxisValueChangeEventArgs args)
        {
            switch(args.ChangedValue)
            {
                case WhichValue.MinPressure:
                    displayedChart.ChartAreas[0].AxisY2.Minimum = args.NewValue;
                    break;

                case WhichValue.MaxPressure:
                    displayedChart.ChartAreas[0].AxisY2.Maximum = args.NewValue;
                    break;

                case WhichValue.MinWater:
                    displayedChart.ChartAreas[0].AxisY.Minimum = args.NewValue;
                    break;

                case WhichValue.MaxWater:
                    displayedChart.ChartAreas[0].AxisY.Maximum = args.NewValue;
                    break;

                case WhichValue.MinSand:
                    displayedChart.ChartAreas[0].AxisY.Minimum = args.NewValue;
                    break;

                case WhichValue.MaxSand:
                    displayedChart.ChartAreas[0].AxisY.Maximum = args.NewValue;
                    break;
            }
            displayedChart.Update();
        }


        /// <summary>
        /// Initalizes the first stage in the data.
        /// </summary>
        /// <param name="firstStage">The first stage number.</param>
        public void IntializeFirstStage(int firstStage)
        {
            StageNumber = firstStage;

            UpdateStageDetails();
        }


        /// <summary>
        /// Changes a series line color on the chart.
        /// </summary>
        /// <param name="line">The line to change.</param>
        /// <param name="color">The color to change it to.</param>
        public void ChangeChartLineColor(WhichLine line, Color color)
        {
            switch(line)
            {
                case WhichLine.Pressure:
                    displayedChart.Series["PressureSeries"].Color = color;
                    displayedChart.ChartAreas[0].AxisY.TitleForeColor = color;
                    break;

                case WhichLine.Water:
                    displayedChart.Series["WaterSeries"].Color = color;
                    displayedChart.ChartAreas[0].AxisY2.TitleForeColor = color;
                    break;

                case WhichLine.Sand:
                    displayedChart.Series["SandSeries"].Color = color;
                    displayedChart.ChartAreas[0].AxisY2.TitleForeColor = color;
                    break;
            }

            displayedChart.Update();
        }

        #endregion

        #region Private

        private void CreateContextMenu()
        {
            contextMenu = new ContextMenu();
            editMode = new MenuItem("Enter Edit Mode", new EventHandler(EditDataMode_Click));
            viewMode = new MenuItem("Enter View Mode", new EventHandler(ViewDataMode_Click));
            contextMenu.MenuItems.Add(editMode);

            displayedChart.ContextMenu = contextMenu;
        }

        /// <summary>
        /// Changes the stage number, and also fills the chart
        /// with the stage details.
        /// </summary>
        /// <param name="previous">A flag to indicate whether or not to decrement.</param>
        private void ChangeStage(bool previous)
        {
            if (previous)
            {
                var prev = stageNumber - 1;
                StageNumber = prev;
            }

            else
            {
                var next = stageNumber + 1;
                StageNumber = next;
            }                

            UpdateStageDetails();
        }

        /// <summary>
        /// Updates the details in the chart.
        /// </summary>
        private void UpdateStageDetails()
        {
            displayedChart.Series["PressureSeries"].Points.Clear();
            displayedChart.Series["WaterSeries"].Points.Clear();
            displayedChart.Series["SandSeries"].Points.Clear();

            displayedChart.Titles["StageTitle"].Text = "Stage: " + stageNumber;

            var parent = this.Parent as GraphDisplayControlScreen; 

            if (parent != null)
            {
                StageData = parent.GetStageDataForStage(stageNumber);

                if(StageData != null)
                {
                    StageData.FillPressureSeries(displayedChart.Series["PressureSeries"]);
                    StageData.FillWaterSeries(displayedChart.Series["WaterSeries"]);
                    StageData.FillSandSeries(displayedChart.Series["SandSeries"]);
                    displayedChart.Update();
                }
            }

        }

        #endregion



        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles when the nextStage button is clicked.
        /// </summary>
        /// <param name="sender">The invoker of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void nextStageButton_Click(object sender, EventArgs e)
        {
            ChangeStage(false);
        }

        /// <summary>
        /// Handles when the previousStage button is clicked.
        /// </summary>
        /// <param name="sender">The invoker of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void previousStageButton_Click(object sender, EventArgs e)
        {
            ChangeStage(true);
        }

        private void EditDataMode_Click(object sender, EventArgs e)
        {
            if(null != ChangeMode)
            {
                ChangeMode(this, new ModeChangeEventArgs(Mode.Edit));
                if(contextMenu.MenuItems.Contains(editMode))
                {
                    contextMenu.MenuItems.Remove(editMode);
                    contextMenu.MenuItems.Add(viewMode);
                }
            }
        }

        private void ViewDataMode_Click(object sender, EventArgs e)
        {
            if(null!= ChangeMode)
            {
                ChangeMode(this, new ModeChangeEventArgs(Mode.View));

                if (contextMenu.MenuItems.Contains(viewMode))
                {
                    contextMenu.MenuItems.Remove(viewMode);
                    contextMenu.MenuItems.Add(editMode);
                }
            }
        }
        #endregion
    }

    [Serializable]
    public class ModeChangeEventArgs : EventArgs
    {
        public Mode Mode { get; private set; }

        public ModeChangeEventArgs(Mode mode)
        {
            Mode = mode;
        }
    }
}