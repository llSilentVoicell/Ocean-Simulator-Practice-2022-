using OceanLib;
using OceanLib.Interfaces;
using System;
using System.Windows.Forms;

namespace OceanSimulator__WinForms_
{
    public partial class OceanForm : Form
    {
        #region [Variables]

        public Ocean myFirstOcean = new Ocean();
        public IOceanView oceanView = new DisplayElements();
        public DisplayElements display = new DisplayElements();

        int iteration = 0;

        #endregion

        #region [Constructor]

        public OceanForm()
        {
            InitializeComponent();
        }

        #endregion

        #region [Events]

        private void OceanForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = iterationLabel;

            oceanDataGridView.MultiSelect = false;

            oceanDataGridView.ColumnCount = 70;
            oceanDataGridView.RowCount = 25;

            iterationsProgressBar.Maximum = display.UserNumIteration;

            oceanDataGridView.Dock = DockStyle.Fill;

            timer.Interval = 500;

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

        #endregion
    }
}
