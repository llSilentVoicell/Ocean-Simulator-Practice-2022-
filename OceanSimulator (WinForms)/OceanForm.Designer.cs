
namespace OceanSimulator__WinForms_
{
    partial class OceanForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OceanForm));
            this.oceanPanel = new System.Windows.Forms.Panel();
            this.oceanDataGridView = new System.Windows.Forms.DataGridView();
            this.iterationLabel = new System.Windows.Forms.Label();
            this.iterationNumLabel = new System.Windows.Forms.Label();
            this.obstaclesLabel = new System.Windows.Forms.Label();
            this.numObstaclesLabel = new System.Windows.Forms.Label();
            this.preysLabel = new System.Windows.Forms.Label();
            this.numPreyLabel = new System.Windows.Forms.Label();
            this.predatorsLabel = new System.Windows.Forms.Label();
            this.numPredatorsLabel = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.iterationsProgressBar = new System.Windows.Forms.ProgressBar();
            this.startSimulationButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.oceanPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oceanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // oceanPanel
            // 
            this.oceanPanel.BackColor = System.Drawing.Color.Transparent;
            this.oceanPanel.Controls.Add(this.oceanDataGridView);
            this.oceanPanel.Location = new System.Drawing.Point(67, 73);
            this.oceanPanel.Name = "oceanPanel";
            this.oceanPanel.Size = new System.Drawing.Size(1120, 403);
            this.oceanPanel.TabIndex = 1;
            // 
            // oceanDataGridView
            // 
            this.oceanDataGridView.AllowUserToAddRows = false;
            this.oceanDataGridView.AllowUserToDeleteRows = false;
            this.oceanDataGridView.AllowUserToResizeColumns = false;
            this.oceanDataGridView.AllowUserToResizeRows = false;
            this.oceanDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.oceanDataGridView.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.oceanDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.oceanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oceanDataGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(81)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(254)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.oceanDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.oceanDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oceanDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.oceanDataGridView.Location = new System.Drawing.Point(0, 0);
            this.oceanDataGridView.Name = "oceanDataGridView";
            this.oceanDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(81)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.oceanDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.oceanDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.oceanDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.oceanDataGridView.RowTemplate.Height = 16;
            this.oceanDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.oceanDataGridView.ShowCellToolTips = false;
            this.oceanDataGridView.Size = new System.Drawing.Size(1120, 403);
            this.oceanDataGridView.TabIndex = 0;
            this.oceanDataGridView.SelectionChanged += new System.EventHandler(this.oceanDataGridView_SelectionChanged);
            // 
            // iterationLabel
            // 
            this.iterationLabel.AutoSize = true;
            this.iterationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iterationLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterationLabel.ForeColor = System.Drawing.Color.White;
            this.iterationLabel.Location = new System.Drawing.Point(83, 37);
            this.iterationLabel.Name = "iterationLabel";
            this.iterationLabel.Size = new System.Drawing.Size(146, 29);
            this.iterationLabel.TabIndex = 2;
            this.iterationLabel.Text = "Iteration:";
            // 
            // iterationNumLabel
            // 
            this.iterationNumLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iterationNumLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterationNumLabel.ForeColor = System.Drawing.Color.White;
            this.iterationNumLabel.Location = new System.Drawing.Point(268, 37);
            this.iterationNumLabel.Name = "iterationNumLabel";
            this.iterationNumLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iterationNumLabel.Size = new System.Drawing.Size(69, 29);
            this.iterationNumLabel.TabIndex = 3;
            this.iterationNumLabel.Text = "num";
            this.iterationNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // obstaclesLabel
            // 
            this.obstaclesLabel.AutoSize = true;
            this.obstaclesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.obstaclesLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obstaclesLabel.ForeColor = System.Drawing.Color.White;
            this.obstaclesLabel.Location = new System.Drawing.Point(385, 37);
            this.obstaclesLabel.Name = "obstaclesLabel";
            this.obstaclesLabel.Size = new System.Drawing.Size(148, 29);
            this.obstaclesLabel.TabIndex = 4;
            this.obstaclesLabel.Text = "Obstacles:";
            // 
            // numObstaclesLabel
            // 
            this.numObstaclesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numObstaclesLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numObstaclesLabel.ForeColor = System.Drawing.Color.White;
            this.numObstaclesLabel.Location = new System.Drawing.Point(560, 37);
            this.numObstaclesLabel.Name = "numObstaclesLabel";
            this.numObstaclesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numObstaclesLabel.Size = new System.Drawing.Size(69, 29);
            this.numObstaclesLabel.TabIndex = 5;
            this.numObstaclesLabel.Text = "num";
            this.numObstaclesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // preysLabel
            // 
            this.preysLabel.AutoSize = true;
            this.preysLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.preysLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preysLabel.ForeColor = System.Drawing.Color.White;
            this.preysLabel.Location = new System.Drawing.Point(669, 37);
            this.preysLabel.Name = "preysLabel";
            this.preysLabel.Size = new System.Drawing.Size(94, 29);
            this.preysLabel.TabIndex = 6;
            this.preysLabel.Text = "Preys:";
            // 
            // numPreyLabel
            // 
            this.numPreyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numPreyLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPreyLabel.ForeColor = System.Drawing.Color.White;
            this.numPreyLabel.Location = new System.Drawing.Point(787, 37);
            this.numPreyLabel.Name = "numPreyLabel";
            this.numPreyLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numPreyLabel.Size = new System.Drawing.Size(69, 29);
            this.numPreyLabel.TabIndex = 7;
            this.numPreyLabel.Text = "num";
            this.numPreyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // predatorsLabel
            // 
            this.predatorsLabel.AutoSize = true;
            this.predatorsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.predatorsLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predatorsLabel.ForeColor = System.Drawing.Color.White;
            this.predatorsLabel.Location = new System.Drawing.Point(896, 37);
            this.predatorsLabel.Name = "predatorsLabel";
            this.predatorsLabel.Size = new System.Drawing.Size(157, 29);
            this.predatorsLabel.TabIndex = 8;
            this.predatorsLabel.Text = "Predators:";
            // 
            // numPredatorsLabel
            // 
            this.numPredatorsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numPredatorsLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPredatorsLabel.ForeColor = System.Drawing.Color.White;
            this.numPredatorsLabel.Location = new System.Drawing.Point(1094, 37);
            this.numPredatorsLabel.Name = "numPredatorsLabel";
            this.numPredatorsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numPredatorsLabel.Size = new System.Drawing.Size(69, 29);
            this.numPredatorsLabel.TabIndex = 9;
            this.numPredatorsLabel.Text = "num";
            this.numPredatorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statsPanel
            // 
            this.statsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statsPanel.Location = new System.Drawing.Point(67, 12);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(1120, 62);
            this.statsPanel.TabIndex = 10;
            // 
            // iterationsProgressBar
            // 
            this.iterationsProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.iterationsProgressBar.Location = new System.Drawing.Point(267, 492);
            this.iterationsProgressBar.Name = "iterationsProgressBar";
            this.iterationsProgressBar.Size = new System.Drawing.Size(720, 23);
            this.iterationsProgressBar.TabIndex = 11;
            // 
            // startSimulationButton
            // 
            this.startSimulationButton.BackColor = System.Drawing.Color.Transparent;
            this.startSimulationButton.FlatAppearance.BorderSize = 0;
            this.startSimulationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(4)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.startSimulationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.startSimulationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startSimulationButton.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSimulationButton.ForeColor = System.Drawing.SystemColors.Window;
            this.startSimulationButton.Location = new System.Drawing.Point(329, 542);
            this.startSimulationButton.Name = "startSimulationButton";
            this.startSimulationButton.Size = new System.Drawing.Size(596, 67);
            this.startSimulationButton.TabIndex = 15;
            this.startSimulationButton.Text = "Start";
            this.startSimulationButton.UseVisualStyleBackColor = false;
            this.startSimulationButton.Click += new System.EventHandler(this.startSimulationButton_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // OceanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OceanSimulator__WinForms_.Properties.Resources.akula_podvodnyj_mir_temnyj_165843_1280x720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1238, 625);
            this.Controls.Add(this.startSimulationButton);
            this.Controls.Add(this.iterationsProgressBar);
            this.Controls.Add(this.numPredatorsLabel);
            this.Controls.Add(this.predatorsLabel);
            this.Controls.Add(this.numPreyLabel);
            this.Controls.Add(this.preysLabel);
            this.Controls.Add(this.numObstaclesLabel);
            this.Controls.Add(this.obstaclesLabel);
            this.Controls.Add(this.iterationNumLabel);
            this.Controls.Add(this.iterationLabel);
            this.Controls.Add(this.oceanPanel);
            this.Controls.Add(this.statsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OceanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.OceanForm_Load);
            this.oceanPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oceanDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel oceanPanel;
        private System.Windows.Forms.DataGridView oceanDataGridView;
        private System.Windows.Forms.Label iterationLabel;
        private System.Windows.Forms.Label iterationNumLabel;
        private System.Windows.Forms.Label obstaclesLabel;
        private System.Windows.Forms.Label numObstaclesLabel;
        private System.Windows.Forms.Label preysLabel;
        private System.Windows.Forms.Label numPreyLabel;
        private System.Windows.Forms.Label predatorsLabel;
        private System.Windows.Forms.Label numPredatorsLabel;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.ProgressBar iterationsProgressBar;
        private System.Windows.Forms.Button startSimulationButton;
        private System.Windows.Forms.Timer timer;
    }
}