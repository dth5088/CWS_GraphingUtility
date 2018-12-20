using System;
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
    public enum SelectedOption
    {
        Before,

        After,

        Between
    }

    public partial class DataManipulationPanel : UserControl
    {

        #region fields

        private SelectedOption selectedOption;

        private bool IsTextValid = false;

        private StageData stageData;

        public event DataChangeEventHandler DataChanged;

        public delegate void DataChangeEventHandler(object o, EventArgs e);

        #endregion

        #region Constructor

        /// <summary>
        /// Constructs a new instance of the <see cref="DataManipulationPanel"/> class.
        /// </summary>
        public DataManipulationPanel()
        {
            InitializeComponent();
            selectedOption = SelectedOption.Before;

        }

        #endregion

        #region Methods

        /// <summary>
        /// Checks a string representation of a time in HH:mm:ss format.
        /// </summary>
        /// <param name="text">The time to check.</param>
        /// <returns>True if the time is in the proper format and is within the range of the data.</returns>
        private bool validateText(string text)
        {
            bool result = false;
            DateTime parsedTime;
            if(text.Contains(","))
            {
                string[] splitStr = text.Split(',');
                if(DateTime.TryParse(splitStr[0], out parsedTime))
                {
                    String.Format("HH:mm:ss", parsedTime);
                    result = true;
                }

                if(DateTime.TryParse(splitStr[1], out parsedTime) && result)
                {
                    string.Format("HH:mm:ss", parsedTime);
                    result = true;
                }

            }
            else
            {
                result = text.Length == 8;
                if(DateTime.TryParse(text, out parsedTime) && result)
                {
                    string.Format("HH:mm:ss", parsedTime);
                    result = true;
                }
            }


            return result;
        }

        /// <summary>
        /// Assign the StageData object.
        /// </summary>
        /// <param name="sd">The StageData object.</param>
        public void AssignStageData(StageData sd)
        {
            stageData = sd;
        }

        public void Initialize(DateTime start, DateTime end)
        {
            allBeforeTextBox.Text = start.ToString("HH:mm:ss");
            allAfterTextBox.Text = end.ToString("HH:mm:ss");
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles when the selected radio button changes.
        /// </summary>
        /// <param name="sender">The invoker of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void radioGroup_CheckedChanged(object sender, EventArgs e)
        {
            string result = null;

            foreach(Control control in this.selectionBox.Controls)
            {
                if(control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if(radio.Checked)
                    {
                        result = radio.Text;
                    }
                }
            }

            switch(result)
            {
                case "Delete All Before":
                    allAfterTextBox.Visible = false;
                    allBeforeTextBox.Visible = true;
                    selectedOption = SelectedOption.Before;
                    break;

                case "Delete All After":
                    allBeforeTextBox.Visible = false;
                    allAfterTextBox.Visible = true;
                    selectedOption = SelectedOption.After;
                    break;

                case "Delete All Between":
                    allBeforeTextBox.Visible = true;
                    allAfterTextBox.Visible = true;
                    selectedOption = SelectedOption.Between;
                    break;

                
            }
        }

        /// <summary>
        /// Handles when the text within the textbox changes.
        /// </summary>
        /// <param name="sender">The invoker of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void RemoveButton_Clicked(object sender, EventArgs e)
        {
            string textToValidate = null;
            bool before = false, after = false, both = false;
            bool toReturn = false;

            switch (selectedOption)
            {

                case SelectedOption.Before:
                    textToValidate = allBeforeTextBox.Text;
                    before = true;
                    break;

                case SelectedOption.After:
                    textToValidate = allAfterTextBox.Text;
                    after = true;
                    break;

                case SelectedOption.Between:
                    textToValidate = allBeforeTextBox.Text;
                    textToValidate += "," + allAfterTextBox.Text;
                    both = true;
                    break;

            }

            if (validateText(textToValidate))
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    if(before)
                    {
                        DateTime dt = DateTime.Parse(textToValidate);
                        if(dt != null)
                        {
                            toReturn = stageData.DeleteAllValuesBefore(dt);
                        }
                    }
                    else if (after)
                    {
                        DateTime dt = DateTime.Parse(textToValidate);
                        if(dt != null)
                        {
                            toReturn = stageData.DeleteAllValuesAfter(dt);
                        }
                    }
                    else if (both)
                    {
                        DateTime f = DateTime.Parse(allBeforeTextBox.Text);
                        DateTime s = DateTime.Parse(allAfterTextBox.Text);
                        toReturn = stageData.DeleteAllValuesBetween(f, s);
                    }
                        
                }
            }

            if(toReturn)
            {
                DialogResult result = MessageBox.Show("Deletion Success!");
                if(result == DialogResult.OK)
                {
                    DataChanged(this, EventArgs.Empty);                    
                }
            }


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var parent = Parent as Utilities;

            if (parent != null)
            {
                parent.CloseDialog();
            }
        }

        private void DataManipulationPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                var parent = Parent as Utilities;
                if (parent != null)
                {
                    stageData = parent.CurrentStage;
                }
            }
        }

        #endregion

    }
}
