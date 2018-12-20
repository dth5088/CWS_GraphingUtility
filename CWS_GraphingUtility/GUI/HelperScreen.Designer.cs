namespace CWS_GraphingUtility.GUI
{
    partial class Utilities
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.annotationPanel = new CWS_GraphingUtility.GUI.Controls.AnnotationPanel();
            this.dataManipulationPanel = new CWS_GraphingUtility.GUI.Controls.DataManipulationPanel();
            this.SuspendLayout();
            // 
            // annotationPanel
            // 
            this.annotationPanel.Location = new System.Drawing.Point(13, 46);
            this.annotationPanel.Name = "annotationPanel";
            this.annotationPanel.Size = new System.Drawing.Size(290, 178);
            this.annotationPanel.TabIndex = 1;
            this.annotationPanel.Visible = false;
            // 
            // dataManipulationPanel
            // 
            this.dataManipulationPanel.Location = new System.Drawing.Point(12, 12);
            this.dataManipulationPanel.Name = "dataManipulationPanel";
            this.dataManipulationPanel.Size = new System.Drawing.Size(290, 250);
            this.dataManipulationPanel.TabIndex = 0;
            this.dataManipulationPanel.Visible = false;
            // 
            // Utilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 270);
            this.ControlBox = false;
            this.Controls.Add(this.annotationPanel);
            this.Controls.Add(this.dataManipulationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Utilities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilities";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DataManipulationPanel dataManipulationPanel;
        public Controls.AnnotationPanel annotationPanel;
    }
}