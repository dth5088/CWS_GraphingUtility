using CWS_GraphingUtility.GUI.Controls;
using CWS_GraphingUtility.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWS_GraphingUtility.GUI
{

    public partial class ChartConfigForm : Form
    {
        #region fields

        private double minP, maxP, minW, maxW, minS, maxS;

        private Color pColor, wColor, sColor;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Minimum Pressure (Min Y Axis Value)
        /// </summary>
        public double MinPressure
        {
            get
            {
                var mp = Resources.PressureMin;
                minP = double.Parse(Resources.PressureMin);
                return minP;
            }

            set
            {
                minP = value;
                axisChangeEvents.Add(new AxisValueChangeEventArgs(minP, WhichValue.MinPressure));
            }

        }

        /// <summary>
        /// Gets or sets the Maximum Pressure (Max Y Axis Value)
        /// </summary>
        public double MaxPressure
        {
            get
            {
                maxP = double.Parse(Resources.PressureMax);
                return maxP;
            }

            set
            {
                maxP = value;
                axisChangeEvents.Add(new AxisValueChangeEventArgs(maxP, WhichValue.MaxPressure));
            }
        }

        /// <summary>
        /// Gets or sets the Minimum Water (Min Y2 Axis Value)
        /// </summary>
        public double MinWater
        {
            get
            {
                minW = double.Parse(Resources.RateMin);
                return minW;
            }
            set
            {
                minW = value;
                axisChangeEvents.Add(new AxisValueChangeEventArgs(minW, WhichValue.MinWater));
            }
        }

        /// <summary>
        /// Gets or sets the Maximum Water  (Min Y2 Axis Value)
        /// </summary>
        public double MaxWater
        {
            get
            {
                maxW = double.Parse(Resources.RateMax);
                return maxW;
            }

            set
            {
                maxW = value;
                axisChangeEvents.Add(new AxisValueChangeEventArgs(maxW, WhichValue.MaxWater));
            }
        }

        /// <summary>
        /// Gets or sets the Minimum Sand (Min Y2 Axis Value)
        /// </summary>
        public double MinSand
        {
            get
            {
                minS = double.Parse(Resources.RateMin);
                return minS;
            }
            set
            {
                minS = value;
                axisChangeEvents.Add(new AxisValueChangeEventArgs(minS, WhichValue.MinSand));
            }
        }

        /// <summary>
        /// Gets or sets the Maximum Sand  (Min Y2 Axis Value)
        /// </summary>
        public double MaxSand
        {
            get
            {
                maxS = double.Parse(Resources.RateMax);
                return maxS;
            }

            set
            {
                maxS = value;
                axisChangeEvents.Add(new AxisValueChangeEventArgs(maxS, WhichValue.MaxSand));
            }
        }

        public Color PressureLineColor
        {
            get
            {
                string colorString = Resources.PressureLineColor;
                if(pColor == Color.Empty && Color.FromName(colorString) != null)
                {
                    pColor = Color.FromName(colorString);
                    return pColor;
                }
                else if (pColor != Color.Empty)
                {
                    return pColor;
                }
                else 
                    return Color.Empty;
            }

            set
            {
                pColor = value;
                pressureLineColor.BackColor = pColor;
            }
        }

        public Color WaterLineColor
        {
            get
            {
                string colorString = Resources.WaterLineColor;
                if (Color.FromName(colorString) != null && wColor == Color.Empty) 
                {
                    wColor = Color.FromName(colorString);
                    return wColor;
                }
                else if (wColor != Color.Empty)
                {
                    return wColor;
                }
                else 
                    return Color.Empty;
            }

            set
            {
                wColor = value;
                waterLineColor.BackColor = wColor;
            }
        }

        public Color SandLineColor
        {
            get
            {
                string colorString = Resources.SandLineColor;
                if (Color.FromName(colorString) != null && sColor == Color.Empty)
                {
                    sColor = Color.FromName(colorString);
                    return sColor;
                }
                else if (sColor != Color.Empty)
                {
                    return sColor;
                }
                else 
                    return Color.Empty;
            }

            set
            {
                sColor = value;
                sandLineColor.BackColor = sColor;
            }
        }

        public delegate void ColorChangeHandler(object sender, ColorChangeEventArgs e);

        public delegate void AxisValueChangeHandler(object sender, AxisValueChangeEventArgs e);

        public event AxisValueChangeHandler AxisValueChange;

        public event ColorChangeHandler ColorChange;

        List<ColorChangeEventArgs> colorChangeEvents = new List<ColorChangeEventArgs>();

        List<AxisValueChangeEventArgs> axisChangeEvents = new List<AxisValueChangeEventArgs>();


        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartConfigForm"/> class.
        /// </summary>
        public ChartConfigForm()
        {
            InitializeComponent();

            AssignDefaults();
        }

        #endregion


        #region Methods

        /// <summary>
        /// Assigns the default values from the resources file.
        /// </summary>
        private void AssignDefaults()
        {
            minPressure.Text = MinPressure.ToString();
            maxPressure.Text = MaxPressure.ToString();

            minWater.Text = MinWater.ToString();
            maxWater.Text = MaxWater.ToString();

            minSand.Text = MinSand.ToString();
            maxSand.Text = MaxSand.ToString();

            pressureLineColor.BackColor = PressureLineColor;
            waterLineColor.BackColor = WaterLineColor;
            sandLineColor.BackColor = SandLineColor;

        }

        #endregion


        #region Event Handlers

        /// <summary>
        /// Handles when the pressureLineColor label is clicked.
        /// </summary>
        /// <param name="sender">The Invoker of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void pressureLineColor_Click(object sender, EventArgs e)
        {
            lineColorDialog.Color = PressureLineColor;
            
            if(lineColorDialog.ShowDialog() == DialogResult.OK)
            {
                PressureLineColor = lineColorDialog.Color;
                colorChangeEvents.Add(new ColorChangeEventArgs(PressureLineColor, "Pressure"));

            }

            
        }

        /// <summary>
        /// Handles when the waterLineColor label is clicked.
        /// </summary>
        /// <param name="sender">The Invoker of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void waterLineColor_Click(object sender, EventArgs e)
        {
            lineColorDialog.Color = WaterLineColor;


            if (lineColorDialog.ShowDialog() == DialogResult.OK)
            {
                WaterLineColor = lineColorDialog.Color;
                colorChangeEvents.Add(new ColorChangeEventArgs(WaterLineColor, "Water"));
            }
        }

        /// <summary>
        /// Handles when the sandLineColor label is clicked.
        /// </summary>
        /// <param name="sender">The Invoker of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void sandLineColor_Click(object sender, EventArgs e)
        {
            lineColorDialog.Color = SandLineColor;


            if (lineColorDialog.ShowDialog() == DialogResult.OK)
            {
                SandLineColor = lineColorDialog.Color;
                colorChangeEvents.Add(new ColorChangeEventArgs(SandLineColor, "Sand"));
            }
        }

        /// <summary>
        /// Handles when the save button clicked.
        /// </summary>
        /// <param name="sender">The Invoker of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            foreach(var ev in colorChangeEvents)
            {
                ColorChange(this, ev);
            }

            foreach(var ev in axisChangeEvents)
            {
                AxisValueChange(this, ev);
            }

            this.Hide();
        }

        /// <summary>
        /// Handles when the cancel button is clicked.
        /// </summary>
        /// <param name="sender">The invoker of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            colorChangeEvents.Clear();
            axisChangeEvents.Clear();
            this.Hide();
        }

        #endregion

    }

    [Serializable]
    public class ColorChangeEventArgs : EventArgs
    {
        public Color Color { get; private set; }

        public string Line { get; private set; }

        public ColorChangeEventArgs(Color color, string line)
        {
            Color = color;
            Line = line;
        }
    }

    [Serializable]
    public class AxisValueChangeEventArgs : EventArgs
    {
        public double NewValue { get; private set; }

        public WhichValue ChangedValue { get; private set; }

        public AxisValueChangeEventArgs(double value, WhichValue wv)
        {
            NewValue = value;
            ChangedValue = wv;
        }
    }
}
