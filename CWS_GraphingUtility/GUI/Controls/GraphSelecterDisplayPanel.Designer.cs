namespace CWS_GraphingUtility.GUI.Controls
{
    partial class GraphSelecterDisplayPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphSelecterDisplayPanel));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.nextStageButton = new System.Windows.Forms.Button();
            this.previousStageButton = new System.Windows.Forms.Button();
            this.stageNumberLabel = new System.Windows.Forms.Label();
            this.stLabel = new System.Windows.Forms.Label();
            this.displayedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ofLabel = new System.Windows.Forms.Label();
            this.totalStagesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayedChart)).BeginInit();
            this.SuspendLayout();
            // 
            // nextStageButton
            // 
            this.nextStageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nextStageButton.Image = ((System.Drawing.Image)(resources.GetObject("nextStageButton.Image")));
            this.nextStageButton.Location = new System.Drawing.Point(619, 621);
            this.nextStageButton.Name = "nextStageButton";
            this.nextStageButton.Size = new System.Drawing.Size(59, 61);
            this.nextStageButton.TabIndex = 2;
            this.nextStageButton.UseVisualStyleBackColor = true;
            this.nextStageButton.Click += new System.EventHandler(this.nextStageButton_Click);
            // 
            // previousStageButton
            // 
            this.previousStageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.previousStageButton.Image = ((System.Drawing.Image)(resources.GetObject("previousStageButton.Image")));
            this.previousStageButton.Location = new System.Drawing.Point(424, 621);
            this.previousStageButton.Name = "previousStageButton";
            this.previousStageButton.Size = new System.Drawing.Size(59, 61);
            this.previousStageButton.TabIndex = 1;
            this.previousStageButton.UseVisualStyleBackColor = true;
            this.previousStageButton.Click += new System.EventHandler(this.previousStageButton_Click);
            // 
            // stageNumberLabel
            // 
            this.stageNumberLabel.AutoSize = true;
            this.stageNumberLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stageNumberLabel.Location = new System.Drawing.Point(500, 634);
            this.stageNumberLabel.Name = "stageNumberLabel";
            this.stageNumberLabel.Size = new System.Drawing.Size(22, 24);
            this.stageNumberLabel.TabIndex = 3;
            this.stageNumberLabel.Text = "1";
            // 
            // stLabel
            // 
            this.stLabel.AutoSize = true;
            this.stLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stLabel.Location = new System.Drawing.Point(513, 658);
            this.stLabel.Name = "stLabel";
            this.stLabel.Size = new System.Drawing.Size(68, 24);
            this.stLabel.TabIndex = 4;
            this.stLabel.Text = "Stage";
            // 
            // displayedChart
            // 
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Maximum = 5000D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Pressure";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.Maximum = 25D;
            chartArea1.AxisY2.Minimum = 0D;
            chartArea1.AxisY2.Title = "Rate";
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea";
            this.displayedChart.ChartAreas.Add(chartArea1);
            legend1.DockedToChartArea = "ChartArea";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Enabled = false;
            legend1.IsDockedInsideChartArea = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.displayedChart.Legends.Add(legend1);
            this.displayedChart.Location = new System.Drawing.Point(0, 3);
            this.displayedChart.Name = "displayedChart";
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "PressureSeries";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "WaterSeries";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.ChartArea = "ChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "SandSeries";
            series3.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.displayedChart.Series.Add(series1);
            this.displayedChart.Series.Add(series2);
            this.displayedChart.Series.Add(series3);
            this.displayedChart.Size = new System.Drawing.Size(1100, 600);
            this.displayedChart.TabIndex = 5;
            title1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "StageTitle";
            title1.Text = "Stage";
            this.displayedChart.Titles.Add(title1);
            // 
            // ofLabel
            // 
            this.ofLabel.AutoSize = true;
            this.ofLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ofLabel.Location = new System.Drawing.Point(528, 634);
            this.ofLabel.Name = "ofLabel";
            this.ofLabel.Size = new System.Drawing.Size(39, 24);
            this.ofLabel.TabIndex = 6;
            this.ofLabel.Text = "OF";
            // 
            // totalStagesLabel
            // 
            this.totalStagesLabel.AutoSize = true;
            this.totalStagesLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStagesLabel.Location = new System.Drawing.Point(573, 634);
            this.totalStagesLabel.Name = "totalStagesLabel";
            this.totalStagesLabel.Size = new System.Drawing.Size(22, 24);
            this.totalStagesLabel.TabIndex = 7;
            this.totalStagesLabel.Text = "1";
            // 
            // GraphSelecterDisplayPanel
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.totalStagesLabel);
            this.Controls.Add(this.ofLabel);
            this.Controls.Add(this.displayedChart);
            this.Controls.Add(this.stLabel);
            this.Controls.Add(this.stageNumberLabel);
            this.Controls.Add(this.nextStageButton);
            this.Controls.Add(this.previousStageButton);
            this.Name = "GraphSelecterDisplayPanel";
            this.Size = new System.Drawing.Size(1100, 700);
            ((System.ComponentModel.ISupportInitialize)(this.displayedChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button previousStageButton;
        private System.Windows.Forms.Button nextStageButton;
        private System.Windows.Forms.Label stageNumberLabel;
        private System.Windows.Forms.Label stLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart displayedChart;
        private System.Windows.Forms.Label ofLabel;
        private System.Windows.Forms.Label totalStagesLabel;
    }
}
