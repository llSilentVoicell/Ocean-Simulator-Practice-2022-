
namespace OceanSimulator__WinForms_
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.numOceansLabel = new System.Windows.Forms.Label();
            this.numPreysLabel = new System.Windows.Forms.Label();
            this.firstOceanLabel = new System.Windows.Forms.Label();
            this.numPredatorsLabel = new System.Windows.Forms.Label();
            this.numObstaclesLabel = new System.Windows.Forms.Label();
            this.secondOceanLabel = new System.Windows.Forms.Label();
            this.numIterationsLabel = new System.Windows.Forms.Label();
            this.firstNumPreysTextBox = new System.Windows.Forms.TextBox();
            this.firstNumPredatorsTextBox = new System.Windows.Forms.TextBox();
            this.firstNumObstaclesTextBox = new System.Windows.Forms.TextBox();
            this.secondNumObstaclesTextBox = new System.Windows.Forms.TextBox();
            this.secondNumPredatorsTextBox = new System.Windows.Forms.TextBox();
            this.secondNumPreysTextBox = new System.Windows.Forms.TextBox();
            this.firstNumIterationsTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.numOceansTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.secondNumIterationsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numOceansLabel
            // 
            this.numOceansLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numOceansLabel.AutoSize = true;
            this.numOceansLabel.BackColor = System.Drawing.Color.Transparent;
            this.numOceansLabel.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOceansLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.numOceansLabel.Location = new System.Drawing.Point(12, 9);
            this.numOceansLabel.Name = "numOceansLabel";
            this.numOceansLabel.Size = new System.Drawing.Size(700, 44);
            this.numOceansLabel.TabIndex = 0;
            this.numOceansLabel.Text = "Enter number  of oceans (1 or 2):";
            // 
            // numPreysLabel
            // 
            this.numPreysLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numPreysLabel.AutoSize = true;
            this.numPreysLabel.BackColor = System.Drawing.Color.Transparent;
            this.numPreysLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPreysLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.numPreysLabel.Location = new System.Drawing.Point(12, 171);
            this.numPreysLabel.Name = "numPreysLabel";
            this.numPreysLabel.Size = new System.Drawing.Size(385, 32);
            this.numPreysLabel.TabIndex = 1;
            this.numPreysLabel.Text = "Enter number  of preys:";
            // 
            // firstOceanLabel
            // 
            this.firstOceanLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstOceanLabel.AutoSize = true;
            this.firstOceanLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstOceanLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstOceanLabel.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.firstOceanLabel.Location = new System.Drawing.Point(505, 110);
            this.firstOceanLabel.Name = "firstOceanLabel";
            this.firstOceanLabel.Size = new System.Drawing.Size(172, 29);
            this.firstOceanLabel.TabIndex = 2;
            this.firstOceanLabel.Text = "First ocean";
            // 
            // numPredatorsLabel
            // 
            this.numPredatorsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numPredatorsLabel.AutoSize = true;
            this.numPredatorsLabel.BackColor = System.Drawing.Color.Transparent;
            this.numPredatorsLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPredatorsLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.numPredatorsLabel.Location = new System.Drawing.Point(12, 212);
            this.numPredatorsLabel.Name = "numPredatorsLabel";
            this.numPredatorsLabel.Size = new System.Drawing.Size(460, 32);
            this.numPredatorsLabel.TabIndex = 3;
            this.numPredatorsLabel.Text = "Enter number  of predators:";
            // 
            // numObstaclesLabel
            // 
            this.numObstaclesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numObstaclesLabel.AutoSize = true;
            this.numObstaclesLabel.BackColor = System.Drawing.Color.Transparent;
            this.numObstaclesLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numObstaclesLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.numObstaclesLabel.Location = new System.Drawing.Point(14, 255);
            this.numObstaclesLabel.Name = "numObstaclesLabel";
            this.numObstaclesLabel.Size = new System.Drawing.Size(450, 32);
            this.numObstaclesLabel.TabIndex = 4;
            this.numObstaclesLabel.Text = "Enter number  of obstacles:";
            // 
            // secondOceanLabel
            // 
            this.secondOceanLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.secondOceanLabel.AutoSize = true;
            this.secondOceanLabel.BackColor = System.Drawing.Color.Transparent;
            this.secondOceanLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondOceanLabel.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.secondOceanLabel.Location = new System.Drawing.Point(732, 110);
            this.secondOceanLabel.Name = "secondOceanLabel";
            this.secondOceanLabel.Size = new System.Drawing.Size(193, 29);
            this.secondOceanLabel.TabIndex = 5;
            this.secondOceanLabel.Text = "Second ocean";
            // 
            // numIterationsLabel
            // 
            this.numIterationsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numIterationsLabel.AutoSize = true;
            this.numIterationsLabel.BackColor = System.Drawing.Color.Transparent;
            this.numIterationsLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIterationsLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.numIterationsLabel.Location = new System.Drawing.Point(12, 335);
            this.numIterationsLabel.Name = "numIterationsLabel";
            this.numIterationsLabel.Size = new System.Drawing.Size(463, 32);
            this.numIterationsLabel.TabIndex = 6;
            this.numIterationsLabel.Text = "Enter number  of iterations:";
            // 
            // firstNumPreysTextBox
            // 
            this.firstNumPreysTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNumPreysTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.firstNumPreysTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNumPreysTextBox.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumPreysTextBox.ForeColor = System.Drawing.Color.CadetBlue;
            this.firstNumPreysTextBox.Location = new System.Drawing.Point(573, 171);
            this.firstNumPreysTextBox.Name = "firstNumPreysTextBox";
            this.firstNumPreysTextBox.Size = new System.Drawing.Size(104, 32);
            this.firstNumPreysTextBox.TabIndex = 7;
            this.firstNumPreysTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.firstNumPreysTextBox.Enter += new System.EventHandler(this.firstNumPreysTextBox_Enter);
            this.firstNumPreysTextBox.Leave += new System.EventHandler(this.firstNumPreysTextBox_Leave);
            // 
            // firstNumPredatorsTextBox
            // 
            this.firstNumPredatorsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNumPredatorsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.firstNumPredatorsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNumPredatorsTextBox.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumPredatorsTextBox.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.firstNumPredatorsTextBox.Location = new System.Drawing.Point(573, 212);
            this.firstNumPredatorsTextBox.Name = "firstNumPredatorsTextBox";
            this.firstNumPredatorsTextBox.Size = new System.Drawing.Size(104, 32);
            this.firstNumPredatorsTextBox.TabIndex = 8;
            this.firstNumPredatorsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.firstNumPredatorsTextBox.Enter += new System.EventHandler(this.firstNumPredatorsTextBox_Enter);
            this.firstNumPredatorsTextBox.Leave += new System.EventHandler(this.firstNumPredatorsTextBox_Leave);
            // 
            // firstNumObstaclesTextBox
            // 
            this.firstNumObstaclesTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNumObstaclesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.firstNumObstaclesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNumObstaclesTextBox.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumObstaclesTextBox.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.firstNumObstaclesTextBox.Location = new System.Drawing.Point(573, 255);
            this.firstNumObstaclesTextBox.Name = "firstNumObstaclesTextBox";
            this.firstNumObstaclesTextBox.Size = new System.Drawing.Size(104, 32);
            this.firstNumObstaclesTextBox.TabIndex = 9;
            this.firstNumObstaclesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.firstNumObstaclesTextBox.Enter += new System.EventHandler(this.firstNumObstaclesTextBox_Enter);
            this.firstNumObstaclesTextBox.Leave += new System.EventHandler(this.firstNumObstaclesTextBox_Leave);
            // 
            // secondNumObstaclesTextBox
            // 
            this.secondNumObstaclesTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.secondNumObstaclesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.secondNumObstaclesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondNumObstaclesTextBox.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumObstaclesTextBox.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.secondNumObstaclesTextBox.Location = new System.Drawing.Point(821, 255);
            this.secondNumObstaclesTextBox.Name = "secondNumObstaclesTextBox";
            this.secondNumObstaclesTextBox.Size = new System.Drawing.Size(104, 32);
            this.secondNumObstaclesTextBox.TabIndex = 12;
            this.secondNumObstaclesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.secondNumObstaclesTextBox.Enter += new System.EventHandler(this.secondNumObstaclesTextBox_Enter);
            this.secondNumObstaclesTextBox.Leave += new System.EventHandler(this.secondNumObstaclesTextBox_Leave);
            // 
            // secondNumPredatorsTextBox
            // 
            this.secondNumPredatorsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.secondNumPredatorsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.secondNumPredatorsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondNumPredatorsTextBox.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumPredatorsTextBox.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.secondNumPredatorsTextBox.Location = new System.Drawing.Point(821, 212);
            this.secondNumPredatorsTextBox.Name = "secondNumPredatorsTextBox";
            this.secondNumPredatorsTextBox.Size = new System.Drawing.Size(104, 32);
            this.secondNumPredatorsTextBox.TabIndex = 11;
            this.secondNumPredatorsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.secondNumPredatorsTextBox.Enter += new System.EventHandler(this.secondNumPredatorsTextBox_Enter);
            this.secondNumPredatorsTextBox.Leave += new System.EventHandler(this.secondNumPredatorsTextBox_Leave);
            // 
            // secondNumPreysTextBox
            // 
            this.secondNumPreysTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.secondNumPreysTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.secondNumPreysTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondNumPreysTextBox.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumPreysTextBox.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.secondNumPreysTextBox.Location = new System.Drawing.Point(821, 171);
            this.secondNumPreysTextBox.Name = "secondNumPreysTextBox";
            this.secondNumPreysTextBox.Size = new System.Drawing.Size(104, 32);
            this.secondNumPreysTextBox.TabIndex = 10;
            this.secondNumPreysTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.secondNumPreysTextBox.Enter += new System.EventHandler(this.secondNumPreysTextBox_Enter);
            this.secondNumPreysTextBox.Leave += new System.EventHandler(this.secondNumPreysTextBox_Leave);
            // 
            // firstNumIterationsTextBox
            // 
            this.firstNumIterationsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.firstNumIterationsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.firstNumIterationsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNumIterationsTextBox.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumIterationsTextBox.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.firstNumIterationsTextBox.Location = new System.Drawing.Point(573, 335);
            this.firstNumIterationsTextBox.Name = "firstNumIterationsTextBox";
            this.firstNumIterationsTextBox.Size = new System.Drawing.Size(104, 32);
            this.firstNumIterationsTextBox.TabIndex = 13;
            this.firstNumIterationsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.firstNumIterationsTextBox.Enter += new System.EventHandler(this.firstNumIterationsTextBox_Enter);
            this.firstNumIterationsTextBox.Leave += new System.EventHandler(this.firstNumIterationsTextBox_Leave);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(4)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(4)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.PaleGreen;
            this.startButton.Location = new System.Drawing.Point(495, 419);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(495, 67);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // numOceansTextBox
            // 
            this.numOceansTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numOceansTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.numOceansTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numOceansTextBox.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOceansTextBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.numOceansTextBox.Location = new System.Drawing.Point(820, 9);
            this.numOceansTextBox.Name = "numOceansTextBox";
            this.numOceansTextBox.Size = new System.Drawing.Size(104, 44);
            this.numOceansTextBox.TabIndex = 15;
            this.numOceansTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numOceansTextBox.Enter += new System.EventHandler(this.numOceansTextBox_Enter);
            this.numOceansTextBox.Leave += new System.EventHandler(this.numOceansTextBox_Leave);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.IndianRed;
            this.backButton.Location = new System.Drawing.Point(0, 419);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(495, 67);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // secondNumIterationsTextBox
            // 
            this.secondNumIterationsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.secondNumIterationsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.secondNumIterationsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondNumIterationsTextBox.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumIterationsTextBox.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.secondNumIterationsTextBox.Location = new System.Drawing.Point(820, 335);
            this.secondNumIterationsTextBox.Name = "secondNumIterationsTextBox";
            this.secondNumIterationsTextBox.Size = new System.Drawing.Size(104, 32);
            this.secondNumIterationsTextBox.TabIndex = 17;
            this.secondNumIterationsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.secondNumIterationsTextBox.Enter += new System.EventHandler(this.secondNumIterationsTextBox_Enter);
            this.secondNumIterationsTextBox.Leave += new System.EventHandler(this.secondNumIterationsTextBox_Leave);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OceanSimulator__WinForms_.Properties.Resources.ocean_settings_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 486);
            this.Controls.Add(this.secondNumIterationsTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.numOceansTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.firstNumIterationsTextBox);
            this.Controls.Add(this.secondNumObstaclesTextBox);
            this.Controls.Add(this.secondNumPredatorsTextBox);
            this.Controls.Add(this.secondNumPreysTextBox);
            this.Controls.Add(this.firstNumObstaclesTextBox);
            this.Controls.Add(this.firstNumPredatorsTextBox);
            this.Controls.Add(this.firstNumPreysTextBox);
            this.Controls.Add(this.numIterationsLabel);
            this.Controls.Add(this.secondOceanLabel);
            this.Controls.Add(this.numObstaclesLabel);
            this.Controls.Add(this.numPredatorsLabel);
            this.Controls.Add(this.firstOceanLabel);
            this.Controls.Add(this.numPreysLabel);
            this.Controls.Add(this.numOceansLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(996, 525);
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numOceansLabel;
        private System.Windows.Forms.Label numPreysLabel;
        private System.Windows.Forms.Label firstOceanLabel;
        private System.Windows.Forms.Label numPredatorsLabel;
        private System.Windows.Forms.Label numObstaclesLabel;
        private System.Windows.Forms.Label secondOceanLabel;
        private System.Windows.Forms.Label numIterationsLabel;
        private System.Windows.Forms.TextBox firstNumPreysTextBox;
        private System.Windows.Forms.TextBox firstNumPredatorsTextBox;
        private System.Windows.Forms.TextBox firstNumObstaclesTextBox;
        private System.Windows.Forms.TextBox secondNumObstaclesTextBox;
        private System.Windows.Forms.TextBox secondNumPredatorsTextBox;
        private System.Windows.Forms.TextBox secondNumPreysTextBox;
        private System.Windows.Forms.TextBox firstNumIterationsTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox numOceansTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox secondNumIterationsTextBox;
    }
}