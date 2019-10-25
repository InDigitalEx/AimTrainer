namespace AimTrainer
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.CountdownTimer = new System.Windows.Forms.Timer(this.components);
            this.CountdownLabel = new System.Windows.Forms.Label();
            this.GameOverTimer = new System.Windows.Forms.Timer(this.components);
            this.GameTarget = new System.Windows.Forms.PictureBox();
            this.GameScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // CountdownTimer
            // 
            this.CountdownTimer.Interval = 1000;
            this.CountdownTimer.Tick += new System.EventHandler(this.CountdownTimer_Tick);
            // 
            // CountdownLabel
            // 
            this.CountdownLabel.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountdownLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CountdownLabel.Location = new System.Drawing.Point(12, 9);
            this.CountdownLabel.Name = "CountdownLabel";
            this.CountdownLabel.Size = new System.Drawing.Size(760, 443);
            this.CountdownLabel.TabIndex = 0;
            this.CountdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameOverTimer
            // 
            this.GameOverTimer.Interval = 60000;
            this.GameOverTimer.Tick += new System.EventHandler(this.GameOverTimer_Tick);
            // 
            // GameTarget
            // 
            this.GameTarget.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GameTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GameTarget.Enabled = false;
            this.GameTarget.ErrorImage = null;
            this.GameTarget.Image = ((System.Drawing.Image)(resources.GetObject("GameTarget.Image")));
            this.GameTarget.InitialImage = null;
            this.GameTarget.Location = new System.Drawing.Point(0, 0);
            this.GameTarget.Name = "GameTarget";
            this.GameTarget.Size = new System.Drawing.Size(30, 30);
            this.GameTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GameTarget.TabIndex = 1;
            this.GameTarget.TabStop = false;
            this.GameTarget.Visible = false;
            this.GameTarget.Click += new System.EventHandler(this.GameTarget_Click);
            // 
            // GameScoreLabel
            // 
            this.GameScoreLabel.AutoSize = true;
            this.GameScoreLabel.ForeColor = System.Drawing.Color.White;
            this.GameScoreLabel.Location = new System.Drawing.Point(13, 438);
            this.GameScoreLabel.Name = "GameScoreLabel";
            this.GameScoreLabel.Size = new System.Drawing.Size(47, 13);
            this.GameScoreLabel.TabIndex = 2;
            this.GameScoreLabel.Text = "Score: 0";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.GameScoreLabel);
            this.Controls.Add(this.GameTarget);
            this.Controls.Add(this.CountdownLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_Closed);
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer CountdownTimer;
        private System.Windows.Forms.Label CountdownLabel;
        private System.Windows.Forms.Timer GameOverTimer;
        private System.Windows.Forms.PictureBox GameTarget;
        private System.Windows.Forms.Label GameScoreLabel;
    }
}