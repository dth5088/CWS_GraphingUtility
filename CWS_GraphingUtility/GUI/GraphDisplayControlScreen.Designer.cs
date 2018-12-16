namespace CWS_GraphingUtility.GUI
{
    partial class GraphDisplayControlScreen
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
            this.graphDisplayPanel = new CWS_GraphingUtility.GUI.Controls.GraphSelecterDisplayPanel();
            this.configButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // graphDisplayPanel
            // 
            this.graphDisplayPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.graphDisplayPanel.Location = new System.Drawing.Point(41, 25);
            this.graphDisplayPanel.Name = "graphDisplayPanel";
            this.graphDisplayPanel.Size = new System.Drawing.Size(1100, 700);
            this.graphDisplayPanel.StageData = null;
            this.graphDisplayPanel.StageNumber = 1;
            this.graphDisplayPanel.TabIndex = 0;
            this.graphDisplayPanel.TotalStages = 0;
            // 
            // configButton
            // 
            this.configButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configButton.Location = new System.Drawing.Point(41, 652);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(75, 73);
            this.configButton.TabIndex = 1;
            this.configButton.Text = "Config";
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // GraphDisplayControlScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.graphDisplayPanel);
            this.Name = "GraphDisplayControlScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraphDisplayControlScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.GraphSelecterDisplayPanel graphDisplayPanel;
        private System.Windows.Forms.Button configButton;
    }
}