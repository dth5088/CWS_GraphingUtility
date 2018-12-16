namespace CWS_GraphingUtility.GUI
{
    partial class GraphHolder
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
            this.button_openFile = new System.Windows.Forms.Button();
            this.labelContinue = new System.Windows.Forms.Label();
            this.jobDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button_openFile
            // 
            this.button_openFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_openFile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openFile.Location = new System.Drawing.Point(185, 81);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(138, 31);
            this.button_openFile.TabIndex = 0;
            this.button_openFile.Text = "Open File";
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // labelContinue
            // 
            this.labelContinue.AutoSize = true;
            this.labelContinue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContinue.Location = new System.Drawing.Point(144, 56);
            this.labelContinue.Name = "labelContinue";
            this.labelContinue.Size = new System.Drawing.Size(232, 19);
            this.labelContinue.TabIndex = 1;
            this.labelContinue.Text = "Click \'Open File\' To Continue.";
            this.labelContinue.Visible = false;
            // 
            // jobDatePicker
            // 
            this.jobDatePicker.Location = new System.Drawing.Point(160, 55);
            this.jobDatePicker.Name = "jobDatePicker";
            this.jobDatePicker.Size = new System.Drawing.Size(200, 20);
            this.jobDatePicker.TabIndex = 2;
            this.jobDatePicker.ValueChanged += new System.EventHandler(this.jobDatePicker_ValueChanged);
            // 
            // GraphHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 171);
            this.Controls.Add(this.jobDatePicker);
            this.Controls.Add(this.labelContinue);
            this.Controls.Add(this.button_openFile);
            this.Name = "GraphHolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.Label labelContinue;
        private System.Windows.Forms.DateTimePicker jobDatePicker;
    }
}