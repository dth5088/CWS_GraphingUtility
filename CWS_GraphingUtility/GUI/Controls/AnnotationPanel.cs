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

        private TimeSpan ConvertToTimeSpan(string timeText)
        {
            bool hasSecs = timeText.Length >= 1;
            bool hasMins = timeText.Length >= 4;
            bool hasHours = timeText.Length == 6;

            int secs, mins, hours;

            if(hasHours)
            {
                int.TryParse(timeText.Substring(0, 2), out hours);
            }
            else
            {
                hours = 0;
            }

            if (hasMins)
            {
                int.TryParse(timeText.Substring(3, 2), out mins);
            }
            else
                mins = 0;

            if (hasSecs)
            {
                int.TryParse(timeText.Substring(6, 2), out secs);
            }
            else
                secs = 0;


            return new TimeSpan(hours, mins, secs);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var parent = Parent as Utilities;

            string comment = commentTextBox.Text;

            if (parent != null)
            {
                string timeText = timeTextBox.Text.Replace(" ", string.Empty).Replace(":",string.Empty);
                bool isValid = timeText.Length >= 2;

                if(isValid && !string.IsNullOrEmpty(comment))
                {
                    
                    AnnotationEventArgs eventArgs = new AnnotationEventArgs(comment, ConvertToTimeSpan(timeText));
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
