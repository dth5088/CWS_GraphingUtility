using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWS_GraphingUtility.GUI.Controls
{
    public partial class AnnotationPanel : UserControl
    {
        public delegate void ChartAnnotationHandler(object o, EventArgs e);

        public event ChartAnnotationHandler AnnotationCreated;

        private string timeText = string.Empty;

        public AnnotationPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears the Comment TextBox of all text.
        /// </summary>
        public void ClearAllText()
        {
            commentTextBox.Text = string.Empty;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var parent = Parent as Utilities;

            string timeString = timeTextBox.Text;

            DateTime dt = DateTime.Parse(timeString);

            if(dt != null && parent != null)
            {

                TimeSpan ts = dt.TimeOfDay;

                parent.CloseDialog();

            }

            if(parent != null)
            {

                string comment = commentTextBox.Text;
                string timeText = timeTextBox.Text;

                DateTime convertedText = DateTime.Parse(timeText);

                if(convertedText != null && !string.IsNullOrEmpty(comment))
                {
                    AnnotationEventArgs eventArgs = new AnnotationEventArgs(comment, convertedText.TimeOfDay);
                    AnnotationCreated(this, eventArgs);
                    parent.CloseDialog();
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

        private void timeTextBox_TextChanged(object sender, EventArgs e)
        {
            timeTextBox.MaxLength = 8;

            CheckChar();

            if(timeTextBox.Text.Length == 2)
            {
                timeTextBox.Text += ":";
            }
        }

        private void CheckChar()
        {
            char last = timeTextBox.Text.Last();

            if(!char.IsDigit(last) && !last.Equals(':'))
            {
                SendKeys.Send("{BACKSPACE}");
            }
        }
    }

    [Serializable]
    public class AnnotationEventArgs : EventArgs
    {
        public string Comment { get; private set; }

        public TimeSpan Time { get; private set; }

        public AnnotationEventArgs(string commentString, TimeSpan time)
        {
            Time = time;
            Comment = commentString;
        }
    }
}
