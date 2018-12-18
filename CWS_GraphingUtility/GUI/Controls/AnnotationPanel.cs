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

            if(parent != null)
            {
                parent.CloseDialog();
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
}
