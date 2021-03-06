﻿using CWS_GraphingUtility.GUI.Controls;
using CWS_GraphingUtility.Utiltity;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWS_GraphingUtility.GUI
{
    public partial class GraphDisplayControlScreen : Form
    {
        #region Fields

        /// <summary>
        /// Reference to the job details.
        /// </summary>
        private JobData jobData;

        /// <summary>
        /// Reference to the config form.
        /// </summary>
        private ChartConfigForm ccf;

        private Utilities utilityScreen;

        private int currentStageNumber = 0;

        #endregion

        #region Properties
        public JobData JobData => jobData;
        #endregion

        #region Constructor

        /// <summary>
        /// Constructs a new instance of the <see cref="GraphDisplayControlScreen"/> class.
        /// </summary>
        public GraphDisplayControlScreen()
        {
            InitializeComponent();

            utilityScreen = new Utilities();

            utilityScreen.annotationPanel.AnnotationCreated += new AnnotationPanel.ChartAnnotationHandler(OnAddAnnotation);
        }

        #endregion

        #region Methods

        #region Public

        /// <summary>
        /// Assigns the job data and creates the first stage.
        /// </summary>
        /// <param name="jd">The Job Details.</param>
        public void AssignJobData(JobData jd)
        {
            // assign the data
            this.jobData = jd;

            // assign the first stage number
            graphDisplayPanel.IntializeFirstStage(jobData.GetFirstStageNumber());

            // assign the total number of stages.
            graphDisplayPanel.TotalStages = jobData.NumberOfStages;

            // initialize the ChartConfigForm.
            ccf = new ChartConfigForm();

            // assign a handler to handle the color change events from the chart config form.
            ccf.ColorChange += new ChartConfigForm.ColorChangeHandler(ChangeChartLineColor);

            // assign a handler to handle the value change events from the chart config form.
            ccf.AxisValueChange += new ChartConfigForm.AxisValueChangeHandler(ChangeChartAxisValue);

            graphDisplayPanel.ChangeMode += new GraphSelecterDisplayPanel.ModeChangeHandler(OnModeChanged);

            graphDisplayPanel.AddAnnotation += new GraphSelecterDisplayPanel.AnnotationHandler(OnAddAnnotation);

            graphDisplayPanel.CallDelete += new GraphSelecterDisplayPanel.StageDeletionHandler(OnStageDeletion);

        }

        /// <summary>
        /// Get the details of a stage by number.
        /// </summary>
        /// <param name="number">The stage number to get.</param>
        /// <returns>The StageData object. </returns>
        public StageData GetStageDataForStage(int number)
        {
            if(jobData != null)
            {

                var stage = jobData.GetDetailsForStage(number);
                currentStageNumber = number;
                utilityScreen.UpdateStageData(stage);
                return stage;
            }
            return null;
        }


        public void UndoAllChanges()
        {
            jobData.UndoAllChanges();
        }

        public void RefreshChart()
        {
            graphDisplayPanel.UpdateChartValues();
        }

        



        #endregion

        #region Private
        
        #endregion

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles when the Config Button is clicked.
        /// </summary>
        /// <param name="sender">The invoker of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void configButton_Click(object sender, EventArgs e)
        {
            ccf.Show();
        }

        /// <summary>
        /// Handles when a ColorChangeEvent is invoked.
        /// </summary>
        /// <param name="f">The invoker of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ChangeChartLineColor(object f, ColorChangeEventArgs e)
        {
            switch(e.Line)
            {
                case "Pressure":
                    graphDisplayPanel.ChangeChartLineColor(GUI.Controls.WhichLine.Pressure, e.Color);
                    break;

                case "Water":
                    graphDisplayPanel.ChangeChartLineColor(GUI.Controls.WhichLine.Water, e.Color);
                    break;

                case "Sand":
                    graphDisplayPanel.ChangeChartLineColor(GUI.Controls.WhichLine.Sand, e.Color);
                    break;
            }
        }

        /// <summary>
        /// Handles when a AxisValueChangeEvent is invoked.
        /// </summary>
        /// <param name="f">The invoker of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ChangeChartAxisValue(object f, AxisValueChangeEventArgs e)
        {
            graphDisplayPanel.UpdateChartScaleValues(e);
        }

        private void OnModeChanged(object sender, ModeChangeEventArgs e)
        {
            string outMode = e.Mode == Mode.Edit ? " Edit" : "View";
            bool editMode = e.Mode == Mode.Edit;

            if (editMode)
            {
                if(e.Beginning != null && e.End != null)
                {
                    utilityScreen.OpenDialog(UtilityMode.DataManipulation, e.Beginning, e.End);
                }
                else
                {
                    utilityScreen.OpenDialog(UtilityMode.DataManipulation, e.Beginning, e.End);
                }
            }

            
        }

        private void OnAddAnnotation(object sender, EventArgs e)
        {
            utilityScreen.OpenDialog(UtilityMode.Annotation);
        }

        private void OnAnnotationCreated(object sender, AnnotationEventArgs e)
        {
            graphDisplayPanel.AddAnnotationToGraph(e.Time, e.Comment);
        }

        private void OnStageDeletion(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to delete stage " + currentStageNumber + " + ?", "Confirmation Prompt", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                jobData.DeleteStage(currentStageNumber);

                
            }
        }
        #endregion
    }
}
