namespace shootingDuck
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startScreen = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.gameName = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.gameOverPanel = new System.Windows.Forms.Panel();
            this.restartButton = new System.Windows.Forms.Button();
            this.endGameLabel = new System.Windows.Forms.Label();
            this.ammoCounter = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.thirdBird = new System.Windows.Forms.PictureBox();
            this.secondBird = new System.Windows.Forms.PictureBox();
            this.firstBird = new System.Windows.Forms.PictureBox();
            this.scoreCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gamePanel.SuspendLayout();
            this.gameOverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thirdBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstBird)).BeginInit();
            this.SuspendLayout();
            // 
            // startScreen
            // 
            this.startScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startScreen.BackgroundImage")));
            this.startScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startScreen.Controls.Add(this.pictureBox3);
            this.startScreen.Controls.Add(this.pictureBox2);
            this.startScreen.Controls.Add(this.pictureBox1);
            this.startScreen.Controls.Add(this.playButton);
            this.startScreen.Controls.Add(this.gameName);
            this.startScreen.Location = new System.Drawing.Point(12, 15);
            this.startScreen.Name = "startScreen";
            this.startScreen.Size = new System.Drawing.Size(689, 10);
            this.startScreen.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(318, 194);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(522, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Peru;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.playButton.Location = new System.Drawing.Point(3, 356);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(683, 64);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.BackColor = System.Drawing.Color.Transparent;
            this.gameName.Font = new System.Drawing.Font("NBA 76ers", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gameName.Location = new System.Drawing.Point(193, 43);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(394, 55);
            this.gameName.TabIndex = 1;
            this.gameName.Text = "Duck Shooter";
            // 
            // gamePanel
            // 
            this.gamePanel.BackgroundImage = global::shootingDuck.Properties.Resources.mybackground;
            this.gamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamePanel.Controls.Add(this.gameOverPanel);
            this.gamePanel.Controls.Add(this.ammoCounter);
            this.gamePanel.Controls.Add(this.timeLabel);
            this.gamePanel.Controls.Add(this.thirdBird);
            this.gamePanel.Controls.Add(this.secondBird);
            this.gamePanel.Controls.Add(this.firstBird);
            this.gamePanel.Controls.Add(this.scoreCounter);
            this.gamePanel.Controls.Add(this.label1);
            this.gamePanel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.gamePanel.Location = new System.Drawing.Point(12, 28);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(689, 407);
            this.gamePanel.TabIndex = 1;
            this.gamePanel.Click += new System.EventHandler(this.gamePanel_Click);
            // 
            // gameOverPanel
            // 
            this.gameOverPanel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverPanel.Controls.Add(this.restartButton);
            this.gameOverPanel.Controls.Add(this.endGameLabel);
            this.gameOverPanel.Location = new System.Drawing.Point(4, 394);
            this.gameOverPanel.Name = "gameOverPanel";
            this.gameOverPanel.Size = new System.Drawing.Size(115, 13);
            this.gameOverPanel.TabIndex = 9;
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Indigo;
            this.restartButton.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restartButton.ForeColor = System.Drawing.Color.White;
            this.restartButton.Location = new System.Drawing.Point(243, 352);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(234, 74);
            this.restartButton.TabIndex = 11;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // endGameLabel
            // 
            this.endGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.endGameLabel.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.endGameLabel.ForeColor = System.Drawing.Color.Red;
            this.endGameLabel.Location = new System.Drawing.Point(37, 57);
            this.endGameLabel.Name = "endGameLabel";
            this.endGameLabel.Size = new System.Drawing.Size(640, 201);
            this.endGameLabel.TabIndex = 9;
            this.endGameLabel.Text = "Game over amk";
            this.endGameLabel.UseCompatibleTextRendering = true;
            this.endGameLabel.Visible = false;
            // 
            // ammoCounter
            // 
            this.ammoCounter.BackColor = System.Drawing.Color.Transparent;
            this.ammoCounter.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ammoCounter.Location = new System.Drawing.Point(3, 39);
            this.ammoCounter.Name = "ammoCounter";
            this.ammoCounter.Size = new System.Drawing.Size(198, 39);
            this.ammoCounter.TabIndex = 7;
            this.ammoCounter.Text = "Ammo: 14";
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(558, -2);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(147, 39);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "Time:  30";
            // 
            // thirdBird
            // 
            this.thirdBird.BackColor = System.Drawing.Color.Transparent;
            this.thirdBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thirdBird.Image = ((System.Drawing.Image)(resources.GetObject("thirdBird.Image")));
            this.thirdBird.Location = new System.Drawing.Point(46, 229);
            this.thirdBird.Name = "thirdBird";
            this.thirdBird.Size = new System.Drawing.Size(66, 44);
            this.thirdBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thirdBird.TabIndex = 4;
            this.thirdBird.TabStop = false;
            this.thirdBird.Click += new System.EventHandler(this.clicked_bird);
            // 
            // secondBird
            // 
            this.secondBird.BackColor = System.Drawing.Color.Transparent;
            this.secondBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.secondBird.Image = ((System.Drawing.Image)(resources.GetObject("secondBird.Image")));
            this.secondBird.Location = new System.Drawing.Point(46, 131);
            this.secondBird.Name = "secondBird";
            this.secondBird.Size = new System.Drawing.Size(66, 44);
            this.secondBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondBird.TabIndex = 3;
            this.secondBird.TabStop = false;
            this.secondBird.Visible = false;
            this.secondBird.Click += new System.EventHandler(this.clicked_bird);
            // 
            // firstBird
            // 
            this.firstBird.BackColor = System.Drawing.Color.Transparent;
            this.firstBird.Image = ((System.Drawing.Image)(resources.GetObject("firstBird.Image")));
            this.firstBird.Location = new System.Drawing.Point(46, 81);
            this.firstBird.Name = "firstBird";
            this.firstBird.Size = new System.Drawing.Size(66, 44);
            this.firstBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstBird.TabIndex = 5;
            this.firstBird.TabStop = false;
            this.firstBird.Click += new System.EventHandler(this.clicked_bird);
            // 
            // scoreCounter
            // 
            this.scoreCounter.AutoSize = true;
            this.scoreCounter.BackColor = System.Drawing.Color.Transparent;
            this.scoreCounter.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.scoreCounter.Location = new System.Drawing.Point(86, 0);
            this.scoreCounter.Name = "scoreCounter";
            this.scoreCounter.Size = new System.Drawing.Size(33, 37);
            this.scoreCounter.TabIndex = 1;
            this.scoreCounter.Text = "0";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.startScreen);
            this.Controls.Add(this.gamePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.startScreen.ResumeLayout(false);
            this.startScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.gameOverPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thirdBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstBird)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel startScreen;
        private Label gameName;
        private Button playButton;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel gamePanel;
        private Label scoreCounter;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox firstBird;
        private PictureBox thirdBird;
        private PictureBox secondBird;
        private Label ammoCounter;
        private Label timeLabel;
        private Panel gameOverPanel;
        private Label endGameLabel;
        private Button restartButton;
    }
}