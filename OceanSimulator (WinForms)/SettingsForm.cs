﻿using OceanLib;
using OceanLib.CustomExceptions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OceanSimulator__WinForms_
{
    public partial class SettingsForm : Form
    {
        #region [Variables]

        public Form ReturnForm;

        private ExceptionInform _inform = new ExceptionInform();

        #endregion

        #region [Constructor]

        public SettingsForm()
        {
            InitializeComponent();
            _inform.RegisterHandler(PrintExceptionMessage);
        }

        #endregion

        #region [Events]

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = numOceansLabel;

            firstNumIterationsTextBox.MaxLength = 4;
            firstNumObstaclesTextBox.MaxLength = 4;
            firstNumPredatorsTextBox.MaxLength = 4;
            firstNumPreysTextBox.MaxLength = 4;
            
            secondNumIterationsTextBox.MaxLength = 4;
            secondNumObstaclesTextBox.MaxLength = 4;
            secondNumPredatorsTextBox.MaxLength = 4;
            secondNumPredatorsTextBox.MaxLength = 4;

            numOceansTextBox.MaxLength = 2;

            SetTextBoxDefaultSettings();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            OceanForm firstOcean = new OceanForm();
            OceanForm secondOcean = new OceanForm();

            int numOceans;
            bool isBigger = false;
            bool isLower = false;

            if (numOceansTextBox.Text == "1")
            {
                SetData(firstOcean, firstNumIterationsTextBox, firstNumObstaclesTextBox, firstNumPredatorsTextBox, firstNumPreysTextBox);
            }
            if(numOceansTextBox.Text == "2")
            {
                SetData(firstOcean, firstNumIterationsTextBox, firstNumObstaclesTextBox, firstNumPredatorsTextBox, firstNumPreysTextBox);
                SetData(secondOcean, secondNumIterationsTextBox, secondNumObstaclesTextBox, secondNumPredatorsTextBox, secondNumPreysTextBox);
            }
            else
            {
                try
                {
                    numOceans = Int32.Parse(numOceansTextBox.Text);

                    isBigger = numOceans > 2;
                    isLower = numOceans <= 0;

                    if(isBigger || isLower)
                    {
                        throw new OceanNumException();
                    }
                }
                catch (OceanNumException ex) when (isBigger || isLower)
                {
                    MessageBox.Show(ex.Message);

                    SetTextBoxDefaultSettings();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    SetTextBoxDefaultSettings();
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturnForm.Show();
        }

        #region [Enters TextBoxes]

        private void firstNumPreysTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(firstNumPreysTextBox);
        }

        private void firstNumPreysTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(firstNumPreysTextBox, Constants.DefaultNumPrey);
        }

        private void firstNumPredatorsTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(firstNumPredatorsTextBox);
        }

        private void firstNumPredatorsTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(firstNumPredatorsTextBox, Constants.DefaultNumPredators);
        }

        private void firstNumObstaclesTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(firstNumObstaclesTextBox);
        }

        private void firstNumObstaclesTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(firstNumObstaclesTextBox, Constants.DefaultNumObstacles);
        }

        private void firstNumIterationsTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(firstNumIterationsTextBox);
        }

        private void firstNumIterationsTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(firstNumIterationsTextBox, Constants.DefaultNumIterations);
        }

        private void secondNumPreysTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(secondNumPreysTextBox);
        }

        private void secondNumPreysTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(secondNumPreysTextBox, Constants.DefaultNumPrey);
        }

        private void secondNumPredatorsTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(secondNumPredatorsTextBox);
        }

        private void secondNumPredatorsTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(secondNumPredatorsTextBox, Constants.DefaultNumPredators);
        }

        private void secondNumObstaclesTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(secondNumObstaclesTextBox);
        }

        private void secondNumObstaclesTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(secondNumObstaclesTextBox, Constants.DefaultNumObstacles);
        }

        private void secondNumIterationsTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(secondNumIterationsTextBox);
        }

        private void secondNumIterationsTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(secondNumIterationsTextBox, Constants.DefaultNumIterations);
        }

        private void numOceansTextBox_Enter(object sender, EventArgs e)
        {
            if (numOceansTextBox.ForeColor == Color.CadetBlue)
            {
                numOceansTextBox.Text = null;
                numOceansTextBox.ForeColor = Color.PaleTurquoise;
            }
        }

        private void numOceansTextBox_Leave(object sender, EventArgs e)
        {
            if (numOceansTextBox.Text == "")
            {
                numOceansTextBox.Text = "1";
                numOceansTextBox.ForeColor = Color.CadetBlue;
            }

            if(numOceansTextBox.Text == "1")
            {
                secondOceanLabel.ForeColor = Color.FromArgb(78, 94, 78);

                secondNumPreysTextBox.Enabled = false;
                secondNumPredatorsTextBox.Enabled = false;
                secondNumObstaclesTextBox.Enabled = false;
                secondNumIterationsTextBox.Enabled = false;
            }

            if(numOceansTextBox.Text == "2")
            {
                secondOceanLabel.ForeColor = Color.DarkSeaGreen;

                secondNumPreysTextBox.Enabled = true;
                secondNumPredatorsTextBox.Enabled = true;
                secondNumObstaclesTextBox.Enabled = true;
                secondNumIterationsTextBox.Enabled = true;
            }
        }

        #endregion

        #endregion

        #region [Methods]

        private void SetData(OceanForm ocean, TextBox iteratinonTextBox, TextBox obstaclesTextBox, TextBox predatorsTextBox, TextBox preysTextBox)
        {
            bool isConvertedIterations;
            bool isConvertedObstacles;
            bool isConvertedPredators;
            bool isConvertedPreys;
            bool isNotOverflowed;

            int maxObjects = Constants.MaxRows * Constants.MaxCols;
            int sumObjects;

            try
            {
                ocean.display.UserNumIteration = Int32.Parse(iteratinonTextBox.Text);

                if (ocean.display.UserNumIteration > Constants.DefaultNumIterations || ocean.display.UserNumIteration <=0)
                {
                    throw new InvalidInputIterationsException();
                }

                isConvertedIterations = true;
            }
            catch (InvalidInputIterationsException ex)
            {
                _inform.Inform(ex.Message);

                SetTextBoxDefaultSettings();

                isConvertedIterations = false;
            }
            catch (Exception ex)
            {
                _inform.Inform(ex.Message);

                SetTextBoxDefaultSettings();

                isConvertedIterations = false;
            }

            (isConvertedObstacles, ocean.display.UserNumObstacles) = CheckNumOfParticipants(ocean.display.UserNumObstacles, obstaclesTextBox);
            (isConvertedPredators, ocean.display.UserNumPredators) = CheckNumOfParticipants(ocean.display.UserNumPredators, predatorsTextBox);
            (isConvertedPreys, ocean.display.UserNumPrey) = CheckNumOfParticipants(ocean.display.UserNumPrey, preysTextBox);

            if (isConvertedIterations && isConvertedObstacles && isConvertedPredators && isConvertedPreys)
            {
                try
                {
                    sumObjects = ocean.display.UserNumObstacles + ocean.display.UserNumPredators + ocean.display.UserNumPrey;

                    if(sumObjects >= maxObjects)
                    {
                        throw new OceanOverflowException();
                    }

                    isNotOverflowed = true;
                }
                catch (OceanOverflowException ex)
                {
                    _inform.Inform(ex.Message);

                    SetTextBoxDefaultSettings();

                    isNotOverflowed = false;
                }
                catch (Exception ex)
                {
                    _inform.Inform(ex.Message);

                    SetTextBoxDefaultSettings();

                    isNotOverflowed = false;
                }

                if (isNotOverflowed)
                {
                    ocean.Show();
                }
            }
        }

        private void EnterTextBox(TextBox numTextBox)
        {
            if (numTextBox.ForeColor == Color.CadetBlue)
            {
                numTextBox.Text = null;
                numTextBox.ForeColor = Color.PaleTurquoise;
            }
        }

        private void LeaveTextBox(TextBox numTextBox, int defaultNum)
        {
            if (numTextBox.Text == "")
            {
                numTextBox.Text = defaultNum.ToString();
                numTextBox.ForeColor = Color.CadetBlue;
            }
        }

        private (bool, int) CheckNumOfParticipants(int numParticipants, TextBox participantsTextBox)
        {
            try
            {
                numParticipants = Int32.Parse(participantsTextBox.Text);

                if (numParticipants <= 0)
                {
                    throw new InvalidValueForObjectsException();
                }

                return (true, numParticipants);
            }
            catch (InvalidValueForObjectsException ex)
            {
                _inform.Inform(ex.Message);

                SetTextBoxDefaultSettings();

                return (false, numParticipants);
            }
            catch (Exception ex)
            {
                _inform.Inform(ex.Message);

                SetTextBoxDefaultSettings();

                return (false, numParticipants);
            }
        }

        private void SetTextBoxDefaultSettings() 
        {
            numOceansTextBox.Text = "1";
            numOceansTextBox.ForeColor = Color.CadetBlue;

            firstNumPreysTextBox.Text = Constants.DefaultNumPrey.ToString();
            firstNumPreysTextBox.ForeColor = Color.CadetBlue;

            firstNumPredatorsTextBox.Text = Constants.DefaultNumPredators.ToString();
            firstNumPredatorsTextBox.ForeColor = Color.CadetBlue;

            firstNumObstaclesTextBox.Text = Constants.DefaultNumObstacles.ToString();
            firstNumObstaclesTextBox.ForeColor = Color.CadetBlue;

            firstNumIterationsTextBox.Text = Constants.DefaultNumIterations.ToString();
            firstNumIterationsTextBox.ForeColor = Color.CadetBlue;

            secondNumPreysTextBox.Text = Constants.DefaultNumPrey.ToString();
            secondNumPreysTextBox.ForeColor = Color.CadetBlue;

            secondNumPredatorsTextBox.Text = Constants.DefaultNumPredators.ToString();
            secondNumPredatorsTextBox.ForeColor = Color.CadetBlue;

            secondNumObstaclesTextBox.Text = Constants.DefaultNumObstacles.ToString();
            secondNumObstaclesTextBox.ForeColor = Color.CadetBlue;

            secondNumIterationsTextBox.Text = Constants.DefaultNumIterations.ToString();
            secondNumIterationsTextBox.ForeColor = Color.CadetBlue;

            secondOceanLabel.ForeColor = Color.FromArgb(78, 94, 78);

            secondNumPreysTextBox.Enabled = false;
            secondNumPredatorsTextBox.Enabled = false;
            secondNumObstaclesTextBox.Enabled = false;
            secondNumIterationsTextBox.Enabled = false;
        }

        void PrintExceptionMessage(string message)
        {
            MessageBox.Show(message);
        }

        #endregion
    }
}
