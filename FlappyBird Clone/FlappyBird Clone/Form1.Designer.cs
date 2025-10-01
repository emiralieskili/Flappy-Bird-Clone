namespace FlappyBird_Clone
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ScoreText = new Label();
            ground1 = new PictureBox();
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            bird = new PictureBox();
            ground2 = new PictureBox();
            ground3 = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ground1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground3).BeginInit();
            SuspendLayout();
            // 
            // ScoreText
            // 
            ScoreText.AutoSize = true;
            ScoreText.BackColor = Color.Transparent;
            ScoreText.Font = new Font("Impact", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreText.Location = new Point(12, 12);
            ScoreText.Name = "ScoreText";
            ScoreText.Size = new Size(142, 45);
            ScoreText.TabIndex = 0;
            ScoreText.Text = "Score:0";
 
            // 
            // ground1
            // 
            ground1.Image = Properties.Resources._base;
            ground1.Location = new Point(1, 388);
            ground1.Name = "ground1";
            ground1.Size = new Size(309, 62);
            ground1.TabIndex = 1;
            ground1.TabStop = false;
            // 
            // pipeTop
            // 
            pipeTop.Image = Properties.Resources.pipe_green_top;
            pipeTop.Location = new Point(454, -250);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(52, 322);
            pipeTop.TabIndex = 2;
            pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.Image = Properties.Resources.pipe_green_bottom;
            pipeBottom.Location = new Point(454, 215);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(52, 293);
            pipeBottom.TabIndex = 3;
            pipeBottom.TabStop = false;
            // 
            // bird
            // 
            bird.BackColor = Color.Transparent;
            bird.Image = Properties.Resources.yellowbird_midflap;
            bird.Location = new Point(120, 159);
            bird.Name = "bird";
            bird.Size = new Size(34, 25);
            bird.TabIndex = 4;
            bird.TabStop = false;
            // 
            // ground2
            // 
            ground2.Image = Properties.Resources._base;
            ground2.Location = new Point(291, 388);
            ground2.Name = "ground2";
            ground2.Size = new Size(333, 62);
            ground2.TabIndex = 5;
            ground2.TabStop = false;
            // 
            // ground3
            // 
            ground3.Image = Properties.Resources._base;
            ground3.Location = new Point(621, 388);
            ground3.Name = "ground3";
            ground3.Size = new Size(337, 62);
            ground3.TabIndex = 6;
            ground3.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ground1);
            Controls.Add(ScoreText);
            Controls.Add(ground3);
            Controls.Add(ground2);
            Controls.Add(bird);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Name = "Form1";
            Text = " ";
            KeyDown += gameKeyIsDown;
            KeyUp += gameKeyIsUp;
            ((System.ComponentModel.ISupportInitialize)ground1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ScoreText;
        private PictureBox ground1;
        private PictureBox pipeTop;
        private PictureBox pipeBottom;
        private PictureBox bird;
        private PictureBox ground2;
        private PictureBox ground3;
        private System.Windows.Forms.Timer gameTimer;
    }
}
