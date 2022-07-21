using OceanLib;
using OceanLib.Interfaces;
using System;
using System.Windows.Forms;
using System.Reflection;

namespace OceanSimulator__WinForms_
{
    public partial class OceanForm : Form
    {
        #region [Variables]

        public Ocean myFirstOcean = new Ocean(false);
        public IOceanView oceanView = new DisplayElements();
        public DisplayElements display = new DisplayElements();

        int iteration = 0;

        #endregion

        #region [Constructor]

        public OceanForm()
        {
            InitializeComponent();
            DoubleBuffered();
        }

        #endregion

        #region [Events]

        private void OceanForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = iterationLabel;

            oceanDataGridView.MultiSelect = false;

            PrepareField(oceanDataGridView, myFirstOcean);

            iterationsProgressBar.Maximum = display.UserNumIteration;

            timer.Interval = Constants.TimerInterval;

            myFirstOcean.Initialize(display);

            DisplayIteration();
        }

        private void startSimulationButton_Click(object sender, EventArgs e)
        {
            if (startSimulationButton.Text == "Start")
            {
                timer.Start();
                startSimulationButton.Text = "Stop";
            }
            else if(startSimulationButton.Text == "Stop")
            {
                timer.Stop();
                startSimulationButton.Text = "Start";
            }
            else if (startSimulationButton.Text == "The simulation is completed")
            {
                this.Close();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (myFirstOcean.NumPrey > 0 && myFirstOcean.NumPredators > 0)
            {
                if (iteration <= display.UserNumIteration)
                {
                    myFirstOcean.Run(iteration);

                    DisplayIteration();
                }
            }

            if (myFirstOcean.NumPrey == 0 || myFirstOcean.NumPredators == 0)
            {
                startSimulationButton.Text = "The simulation is completed";
            }

            if (iterationsProgressBar.Value == display.UserNumIteration)
            {
                startSimulationButton.Text = "The simulation is completed";
            }
        }

        private void oceanDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataGridView)sender).SelectedCells[0].Selected = false;
            }
            catch { }
        }

        #endregion

        #region [Methods]

        private void DisplayIteration()
        {
            display.CountParticipants(myFirstOcean);
            display.DisplayStats(iterationNumLabel, numObstaclesLabel, numPreyLabel, numPredatorsLabel, myFirstOcean, iteration, iterationsProgressBar);
            display.DisplayOcean(oceanDataGridView, myFirstOcean);

            iteration++;
        }

        private void PrepareField(DataGridView gridView, Ocean owner)
        {
            for(int i = 0; i < owner.NumCols; i++)
            {
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                imageCol.DefaultCellStyle.NullValue = null;

                gridView.Columns.Add(imageCol);
                gridView.Columns[i].Width = 16;
            }

            for (int i = 0; i < owner.NumRows; i++)
            {
                gridView.Rows.Add();
                gridView.Rows[i].Height = 16;
            }
        }

        private new void DoubleBuffered()
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            oceanDataGridView, new object[] 
            { 
                true 
            });
        }

        #endregion
    }
}
