using CWS_GraphingUtility.Utiltity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWS_GraphingUtility.GUI
{
    public partial class GraphHolder : Form
    {
        private JobData jobData;
        private DateTime jobDate;

        public GraphHolder()
        {
            InitializeComponent();
        }


        #region Event Handlers

        /// <summary>
        /// Handles when the OpenFile Button is Clicked.
        /// </summary>
        /// <param name="sender">The invoker of the event (the button).</param>
        /// <param name="e">The event arguments (the click).</param>
        private void button_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Select a Job (JSON) File",
                DefaultExt = ".json",
                Filter = "json files (*.json)|*.json|All files(*.*|*.*"
            };

            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK) {
                string file = openFileDialog.FileName;
                jobData = new JobData(file, jobDate);
                
            }

            if(jobData != null)
            {
                GraphDisplayControlScreen graphDisplayControlScreen = new GraphDisplayControlScreen();
                graphDisplayControlScreen.AssignJobData(jobData);
                graphDisplayControlScreen.Show();
                this.Hide();
            }
        }

        /// <summary>
        /// Handles when the DatePicker value is changed.
        /// </summary>
        /// <param name="sender">The invoker of the event (the datePicker).</param>
        /// <param name="e">The event arguments ( the changed value).</param>
        private void jobDatePicker_ValueChanged(object sender, EventArgs e)
        {
            jobDate = jobDatePicker.Value;
            jobDatePicker.Visible = false;
            labelContinue.Visible = true;
        }

        #endregion
    }
}
