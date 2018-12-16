namespace CWS_GraphingUtility.GUI
{
    partial class ChartConfigForm
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
            this.minPressureLabel = new System.Windows.Forms.Label();
            this.maxPressureLabel = new System.Windows.Forms.Label();
            this.minWaterLabel = new System.Windows.Forms.Label();
            this.maxWaterLabel = new System.Windows.Forms.Label();
            this.minSandLabel = new System.Windows.Forms.Label();
            this.maxSandLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minPressure = new System.Windows.Forms.TextBox();
            this.maxPressure = new System.Windows.Forms.TextBox();
            this.minWater = new System.Windows.Forms.TextBox();
            this.maxWater = new System.Windows.Forms.TextBox();
            this.minSand = new System.Windows.Forms.TextBox();
            this.maxSand = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pressureLineColor = new System.Windows.Forms.Label();
            this.waterLineColor = new System.Windows.Forms.Label();
            this.sandLineColor = new System.Windows.Forms.Label();
            this.lineColorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // minPressureLabel
            // 
            this.minPressureLabel.AutoSize = true;
            this.minPressureLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minPressureLabel.Location = new System.Drawing.Point(11, 22);
            this.minPressureLabel.Name = "minPressureLabel";
            this.minPressureLabel.Size = new System.Drawing.Size(166, 16);
            this.minPressureLabel.TabIndex = 0;
            this.minPressureLabel.Text = "Minimum Pressure Value";
            // 
            // maxPressureLabel
            // 
            this.maxPressureLabel.AutoSize = true;
            this.maxPressureLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPressureLabel.Location = new System.Drawing.Point(7, 52);
            this.maxPressureLabel.Name = "maxPressureLabel";
            this.maxPressureLabel.Size = new System.Drawing.Size(170, 16);
            this.maxPressureLabel.TabIndex = 1;
            this.maxPressureLabel.Text = "Maximum Pressure Value";
            // 
            // minWaterLabel
            // 
            this.minWaterLabel.AutoSize = true;
            this.minWaterLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minWaterLabel.Location = new System.Drawing.Point(35, 82);
            this.minWaterLabel.Name = "minWaterLabel";
            this.minWaterLabel.Size = new System.Drawing.Size(142, 16);
            this.minWaterLabel.TabIndex = 2;
            this.minWaterLabel.Text = "Minimum Water Rate";
            // 
            // maxWaterLabel
            // 
            this.maxWaterLabel.AutoSize = true;
            this.maxWaterLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxWaterLabel.Location = new System.Drawing.Point(35, 112);
            this.maxWaterLabel.Name = "maxWaterLabel";
            this.maxWaterLabel.Size = new System.Drawing.Size(146, 16);
            this.maxWaterLabel.TabIndex = 3;
            this.maxWaterLabel.Text = "Maximum Water Rate";
            // 
            // minSandLabel
            // 
            this.minSandLabel.AutoSize = true;
            this.minSandLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minSandLabel.Location = new System.Drawing.Point(44, 142);
            this.minSandLabel.Name = "minSandLabel";
            this.minSandLabel.Size = new System.Drawing.Size(137, 16);
            this.minSandLabel.TabIndex = 4;
            this.minSandLabel.Text = "Minimum Sand Rate";
            // 
            // maxSandLabel
            // 
            this.maxSandLabel.AutoSize = true;
            this.maxSandLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxSandLabel.Location = new System.Drawing.Point(40, 172);
            this.maxSandLabel.Name = "maxSandLabel";
            this.maxSandLabel.Size = new System.Drawing.Size(141, 16);
            this.maxSandLabel.TabIndex = 5;
            this.maxSandLabel.Text = "Maximum Sand Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pressure Line Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Water Rate Line Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sand Rate Line Color";
            // 
            // minPressure
            // 
            this.minPressure.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minPressure.Location = new System.Drawing.Point(183, 19);
            this.minPressure.Name = "minPressure";
            this.minPressure.Size = new System.Drawing.Size(100, 22);
            this.minPressure.TabIndex = 9;
            // 
            // maxPressure
            // 
            this.maxPressure.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPressure.Location = new System.Drawing.Point(183, 49);
            this.maxPressure.Name = "maxPressure";
            this.maxPressure.Size = new System.Drawing.Size(100, 22);
            this.maxPressure.TabIndex = 10;
            // 
            // minWater
            // 
            this.minWater.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minWater.Location = new System.Drawing.Point(183, 79);
            this.minWater.Name = "minWater";
            this.minWater.Size = new System.Drawing.Size(100, 22);
            this.minWater.TabIndex = 11;
            // 
            // maxWater
            // 
            this.maxWater.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxWater.Location = new System.Drawing.Point(183, 109);
            this.maxWater.Name = "maxWater";
            this.maxWater.Size = new System.Drawing.Size(100, 22);
            this.maxWater.TabIndex = 12;
            // 
            // minSand
            // 
            this.minSand.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minSand.Location = new System.Drawing.Point(183, 139);
            this.minSand.Name = "minSand";
            this.minSand.Size = new System.Drawing.Size(100, 22);
            this.minSand.TabIndex = 13;
            // 
            // maxSand
            // 
            this.maxSand.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxSand.Location = new System.Drawing.Point(183, 169);
            this.maxSand.Name = "maxSand";
            this.maxSand.Size = new System.Drawing.Size(100, 22);
            this.maxSand.TabIndex = 14;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(79, 293);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(56, 29);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(141, 293);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(61, 29);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pressureLineColor
            // 
            this.pressureLineColor.Location = new System.Drawing.Point(183, 199);
            this.pressureLineColor.Name = "pressureLineColor";
            this.pressureLineColor.Size = new System.Drawing.Size(100, 22);
            this.pressureLineColor.TabIndex = 20;
            this.pressureLineColor.Click += new System.EventHandler(this.pressureLineColor_Click);
            // 
            // waterLineColor
            // 
            this.waterLineColor.Location = new System.Drawing.Point(183, 229);
            this.waterLineColor.Name = "waterLineColor";
            this.waterLineColor.Size = new System.Drawing.Size(100, 22);
            this.waterLineColor.TabIndex = 21;
            this.waterLineColor.Click += new System.EventHandler(this.waterLineColor_Click);
            // 
            // sandLineColor
            // 
            this.sandLineColor.Location = new System.Drawing.Point(183, 262);
            this.sandLineColor.Name = "sandLineColor";
            this.sandLineColor.Size = new System.Drawing.Size(100, 22);
            this.sandLineColor.TabIndex = 22;
            this.sandLineColor.Click += new System.EventHandler(this.sandLineColor_Click);
            // 
            // ChartConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 335);
            this.Controls.Add(this.sandLineColor);
            this.Controls.Add(this.waterLineColor);
            this.Controls.Add(this.pressureLineColor);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.maxSand);
            this.Controls.Add(this.minSand);
            this.Controls.Add(this.maxWater);
            this.Controls.Add(this.minWater);
            this.Controls.Add(this.maxPressure);
            this.Controls.Add(this.minPressure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxSandLabel);
            this.Controls.Add(this.minSandLabel);
            this.Controls.Add(this.maxWaterLabel);
            this.Controls.Add(this.minWaterLabel);
            this.Controls.Add(this.maxPressureLabel);
            this.Controls.Add(this.minPressureLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChartConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minPressureLabel;
        private System.Windows.Forms.Label maxPressureLabel;
        private System.Windows.Forms.Label minWaterLabel;
        private System.Windows.Forms.Label maxWaterLabel;
        private System.Windows.Forms.Label minSandLabel;
        private System.Windows.Forms.Label maxSandLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minPressure;
        private System.Windows.Forms.TextBox maxPressure;
        private System.Windows.Forms.TextBox minWater;
        private System.Windows.Forms.TextBox maxWater;
        private System.Windows.Forms.TextBox minSand;
        private System.Windows.Forms.TextBox maxSand;
        private System.Windows.Forms.TextBox waterColor;
        private System.Windows.Forms.TextBox sandColor;
        private System.Windows.Forms.TextBox pressureColor;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label pressureLineColor;
        private System.Windows.Forms.Label waterLineColor;
        private System.Windows.Forms.Label sandLineColor;
        private System.Windows.Forms.ColorDialog lineColorDialog;
    }
}