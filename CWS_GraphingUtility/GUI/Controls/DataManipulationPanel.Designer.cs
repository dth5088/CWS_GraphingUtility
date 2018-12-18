namespace CWS_GraphingUtility.GUI.Controls
{
    partial class DataManipulationPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.allBeforeRadioButton = new System.Windows.Forms.RadioButton();
            this.allAfterRadioButton = new System.Windows.Forms.RadioButton();
            this.allBetweenRadioButton = new System.Windows.Forms.RadioButton();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.allBeforeTextBox = new System.Windows.Forms.TextBox();
            this.allAfterTextBox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.selectionBox = new System.Windows.Forms.GroupBox();
            this.selectionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // allBeforeRadioButton
            // 
            this.allBeforeRadioButton.AutoSize = true;
            this.allBeforeRadioButton.Checked = true;
            this.allBeforeRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allBeforeRadioButton.Location = new System.Drawing.Point(6, 29);
            this.allBeforeRadioButton.Name = "allBeforeRadioButton";
            this.allBeforeRadioButton.Size = new System.Drawing.Size(152, 23);
            this.allBeforeRadioButton.TabIndex = 2;
            this.allBeforeRadioButton.TabStop = true;
            this.allBeforeRadioButton.Text = "Delete All Before";
            this.allBeforeRadioButton.UseVisualStyleBackColor = true;
            this.allBeforeRadioButton.CheckedChanged += new System.EventHandler(this.radioGroup_CheckedChanged);
            // 
            // allAfterRadioButton
            // 
            this.allAfterRadioButton.AutoSize = true;
            this.allAfterRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allAfterRadioButton.Location = new System.Drawing.Point(6, 0);
            this.allAfterRadioButton.Name = "allAfterRadioButton";
            this.allAfterRadioButton.Size = new System.Drawing.Size(136, 23);
            this.allAfterRadioButton.TabIndex = 3;
            this.allAfterRadioButton.Text = "Delete All After";
            this.allAfterRadioButton.UseVisualStyleBackColor = true;
            this.allAfterRadioButton.CheckedChanged += new System.EventHandler(this.radioGroup_CheckedChanged);
            // 
            // allBetweenRadioButton
            // 
            this.allBetweenRadioButton.AutoSize = true;
            this.allBetweenRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allBetweenRadioButton.Location = new System.Drawing.Point(6, 58);
            this.allBetweenRadioButton.Name = "allBetweenRadioButton";
            this.allBetweenRadioButton.Size = new System.Drawing.Size(168, 23);
            this.allBetweenRadioButton.TabIndex = 4;
            this.allBetweenRadioButton.Text = "Delete All Between";
            this.allBetweenRadioButton.UseVisualStyleBackColor = true;
            this.allBetweenRadioButton.CheckedChanged += new System.EventHandler(this.radioGroup_CheckedChanged);
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel.Location = new System.Drawing.Point(45, 105);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(200, 19);
            this.InstructionLabel.TabIndex = 5;
            this.InstructionLabel.Text = "Please Enter a Valid Time";
            // 
            // allBeforeTextBox
            // 
            this.allBeforeTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allBeforeTextBox.Location = new System.Drawing.Point(83, 127);
            this.allBeforeTextBox.Name = "allBeforeTextBox";
            this.allBeforeTextBox.Size = new System.Drawing.Size(100, 26);
            this.allBeforeTextBox.TabIndex = 6;
            // 
            // allAfterTextBox
            // 
            this.allAfterTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allAfterTextBox.Location = new System.Drawing.Point(83, 159);
            this.allAfterTextBox.Name = "allAfterTextBox";
            this.allAfterTextBox.Size = new System.Drawing.Size(100, 26);
            this.allAfterTextBox.TabIndex = 7;
            this.allAfterTextBox.Visible = false;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(53, 203);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(82, 38);
            this.RemoveButton.TabIndex = 8;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(141, 203);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(82, 38);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // selectionBox
            // 
            this.selectionBox.Controls.Add(this.allBetweenRadioButton);
            this.selectionBox.Controls.Add(this.allBeforeRadioButton);
            this.selectionBox.Controls.Add(this.allAfterRadioButton);
            this.selectionBox.Location = new System.Drawing.Point(45, 3);
            this.selectionBox.Name = "selectionBox";
            this.selectionBox.Size = new System.Drawing.Size(200, 83);
            this.selectionBox.TabIndex = 10;
            this.selectionBox.TabStop = false;
            // 
            // DataManipulationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectionBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.allAfterTextBox);
            this.Controls.Add(this.allBeforeTextBox);
            this.Controls.Add(this.InstructionLabel);
            this.Name = "DataManipulationPanel";
            this.Size = new System.Drawing.Size(290, 250);
            this.VisibleChanged += new System.EventHandler(this.DataManipulationPanel_VisibleChanged);
            this.selectionBox.ResumeLayout(false);
            this.selectionBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton allBeforeRadioButton;
        private System.Windows.Forms.RadioButton allAfterRadioButton;
        private System.Windows.Forms.RadioButton allBetweenRadioButton;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.TextBox allBeforeTextBox;
        private System.Windows.Forms.TextBox allAfterTextBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox selectionBox;
    }
}
