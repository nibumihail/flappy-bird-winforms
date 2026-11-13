namespace FlappyBirdWinForms
{
    partial class Form1
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
            this.pictureBoxBird = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeTop = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeBottom = new System.Windows.Forms.PictureBox();
            this.pictureBoxGround = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBird
            // 
            this.pictureBoxBird.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBird.Image = global::FlappyBirdWinForms.Properties.Resources.aripasus;
            this.pictureBoxBird.Location = new System.Drawing.Point(1, 187);
            this.pictureBoxBird.Name = "pictureBoxBird";
            this.pictureBoxBird.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBird.TabIndex = 0;
            this.pictureBoxBird.TabStop = false;
            // 
            // pictureBoxPipeTop
            // 
            this.pictureBoxPipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPipeTop.Image = global::FlappyBirdWinForms.Properties.Resources.teavasus;
            this.pictureBoxPipeTop.Location = new System.Drawing.Point(188, 0);
            this.pictureBoxPipeTop.Name = "pictureBoxPipeTop";
            this.pictureBoxPipeTop.Size = new System.Drawing.Size(57, 144);
            this.pictureBoxPipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPipeTop.TabIndex = 1;
            this.pictureBoxPipeTop.TabStop = false;
            // 
            // pictureBoxPipeBottom
            // 
            this.pictureBoxPipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPipeBottom.Image = global::FlappyBirdWinForms.Properties.Resources.teavajos;
            this.pictureBoxPipeBottom.Location = new System.Drawing.Point(188, 299);
            this.pictureBoxPipeBottom.Name = "pictureBoxPipeBottom";
            this.pictureBoxPipeBottom.Size = new System.Drawing.Size(57, 203);
            this.pictureBoxPipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPipeBottom.TabIndex = 2;
            this.pictureBoxPipeBottom.TabStop = false;
            // 
            // pictureBoxGround
            // 
            this.pictureBoxGround.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGround.Location = new System.Drawing.Point(1, 501);
            this.pictureBoxGround.Name = "pictureBoxGround";
            this.pictureBoxGround.Size = new System.Drawing.Size(379, 50);
            this.pictureBoxGround.TabIndex = 3;
            this.pictureBoxGround.TabStop = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelScore.Location = new System.Drawing.Point(8, 12);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(70, 25);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "Scor:0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(150, 213);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(95, 32);
            this.buttonRestart.TabIndex = 5;
            this.buttonRestart.Text = "Restart Joc";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Visible = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FlappyBirdWinForms.Properties.Resources.flappy_bird_wallpaper__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.pictureBoxBird);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.pictureBoxPipeBottom);
            this.Controls.Add(this.pictureBoxPipeTop);
            this.Controls.Add(this.pictureBoxGround);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBird;
        private System.Windows.Forms.PictureBox pictureBoxPipeTop;
        private System.Windows.Forms.PictureBox pictureBoxPipeBottom;
        private System.Windows.Forms.PictureBox pictureBoxGround;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button buttonRestart;
    }
}

