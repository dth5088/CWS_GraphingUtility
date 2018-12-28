using CWS_GraphingUtility.Utiltity;
using System;
using System.Windows.Forms;

namespace CWS_GraphingUtility.GUI
{
    /// <summary>
    /// Type used to specify what mode the form is in.
    /// </summary>
    [Serializable]
    public enum UtilityMode
    {
        Annotation,

        DataManipulation
    }

    public partial class Utilities : Form
    {

        #region Constructors

        public Utilities()
        {
            InitializeComponent();

            dataManipulationPanel.DataChanged += new Controls.DataManipulationPanel.DataChangeEventHandler(OnDataChanged);
        }

        #endregion

        
        #region Properties


        public StageData CurrentStage {get; private set; }

        #endregion


        #region Methods

        #region Public

        /// <summary>
        /// Displays the form, making the child control visible
        /// based on the passed UtilityMode.
        /// </summary>
        /// <param name="mode">The mode of the form.</param>
        public void OpenDialog(UtilityMode mode)
        {
            switch(mode)
            {
                case UtilityMode.Annotation:
                    annotationPanel.Visible = true;
                    break;

                case UtilityMode.DataManipulation:
                    dataManipulationPanel.Visible = true;
                    break;
            }

            Show();
        }

        public void OpenDialog(UtilityMode mode, DateTime start, DateTime end)
        {

            bool canContinue = mode == UtilityMode.DataManipulation;

            if(canContinue)
            {
                
                dataManipulationPanel.Visible = true;
                dataManipulationPanel.Initialize(start, end);
                Show();
            }
        }

        /// <summary>
        /// Hides the form.
        /// </summary>
        public void CloseDialog()
        {
            annotationPanel.Visible = false;
            dataManipulationPanel.Visible = false;



            Hide();
        }

        public void UpdateStageData(StageData sd)
        {
            if (CurrentStage != sd)
            {
                CurrentStage = sd;
            }
        }

        private void OnDataChanged(object sender, EventArgs e)
        {
            var parent = Parent as GraphDisplayControlScreen;

            if(parent != null)
            {
                parent.RefreshChart();
            }
            CloseDialog();
        }



        #endregion


        #endregion

    }
}
