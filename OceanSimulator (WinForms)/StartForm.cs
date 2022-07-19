using System;
using System.Windows.Forms;

namespace OceanSimulator__WinForms_
{
    public partial class StartForm : Form
    {
        #region [Constructor]

        public StartForm()
        {
            InitializeComponent();
        }

        #endregion

        #region [Events]

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsForm settings = new SettingsForm() { ReturnForm = this };
            settings.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}