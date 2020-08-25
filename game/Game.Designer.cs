namespace game
{
    partial class GAME
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
            this.player = new System.Windows.Forms.PictureBox();
            this.pic04 = new System.Windows.Forms.PictureBox();
            this.tmMain = new System.Windows.Forms.Timer(this.components);
            this.pic02 = new System.Windows.Forms.PictureBox();
            this.pic01 = new System.Windows.Forms.PictureBox();
            this.pic03 = new System.Windows.Forms.PictureBox();
            this.lbHeart = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.ptbFish01 = new System.Windows.Forms.PictureBox();
            this.ptbFish07 = new System.Windows.Forms.PictureBox();
            this.ptbFish15 = new System.Windows.Forms.PictureBox();
            this.ptbFish20 = new System.Windows.Forms.PictureBox();
            this.ptbFish40 = new System.Windows.Forms.PictureBox();
            this.lbGameOver = new System.Windows.Forms.Label();
            this.ship = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer_Heart = new System.Windows.Forms.Timer(this.components);
            this.timer_soundPlay = new System.Windows.Forms.Timer(this.components);
            this.haveboom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFish01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFish07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFish15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFish20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFish40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Image = global::game.Properties.Resources.lv01Right;
            this.player.Location = new System.Drawing.Point(410, 217);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(70, 50);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // pic04
            // 
            this.pic04.Image = global::game.Properties.Resources.fish01pointRight;
            this.pic04.Location = new System.Drawing.Point(37, 241);
            this.pic04.Name = "pic04";
            this.pic04.Size = new System.Drawing.Size(77, 26);
            this.pic04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic04.TabIndex = 4;
            this.pic04.TabStop = false;
            this.pic04.Tag = "f01Right";
            // 
            // tmMain
            // 
            this.tmMain.Enabled = true;
            this.tmMain.Interval = 50;
            this.tmMain.Tick += new System.EventHandler(this.tmMain_Tick);
            // 
            // pic02
            // 
            this.pic02.Image = global::game.Properties.Resources.fish01pointLeft;
            this.pic02.Location = new System.Drawing.Point(896, 493);
            this.pic02.Name = "pic02";
            this.pic02.Size = new System.Drawing.Size(60, 30);
            this.pic02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic02.TabIndex = 1;
            this.pic02.TabStop = false;
            this.pic02.Tag = "f01Left";
            // 
            // pic01
            // 
            this.pic01.Image = global::game.Properties.Resources.fish01pointLeft;
            this.pic01.Location = new System.Drawing.Point(929, 387);
            this.pic01.Name = "pic01";
            this.pic01.Size = new System.Drawing.Size(60, 30);
            this.pic01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic01.TabIndex = 2;
            this.pic01.TabStop = false;
            this.pic01.Tag = "f01Left";
            // 
            // pic03
            // 
            this.pic03.Image = global::game.Properties.Resources.fish01pointRight;
            this.pic03.Location = new System.Drawing.Point(37, 387);
            this.pic03.Name = "pic03";
            this.pic03.Size = new System.Drawing.Size(68, 33);
            this.pic03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic03.TabIndex = 3;
            this.pic03.TabStop = false;
            this.pic03.Tag = "f01Right";
            // 
            // lbHeart
            // 
            this.lbHeart.AutoSize = true;
            this.lbHeart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbHeart.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeart.ForeColor = System.Drawing.Color.Navy;
            this.lbHeart.Location = new System.Drawing.Point(571, 4);
            this.lbHeart.Name = "lbHeart";
            this.lbHeart.Size = new System.Drawing.Size(78, 23);
            this.lbHeart.TabIndex = 5;
            this.lbHeart.Text = "Heart: 3";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbScore.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.Navy;
            this.lbScore.Location = new System.Drawing.Point(459, 4);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(79, 23);
            this.lbScore.TabIndex = 6;
            this.lbScore.Text = "Score: 0";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbLevel.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.ForeColor = System.Drawing.Color.Red;
            this.lbLevel.Location = new System.Drawing.Point(12, 8);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(160, 47);
            this.lbLevel.TabIndex = 7;
            this.lbLevel.Text = "LEVEL 01";
            // 
            // ptbFish01
            // 
            this.ptbFish01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbFish01.Image = global::game.Properties.Resources.fish01pointRight;
            this.ptbFish01.Location = new System.Drawing.Point(678, 3);
            this.ptbFish01.Name = "ptbFish01";
            this.ptbFish01.Size = new System.Drawing.Size(65, 47);
            this.ptbFish01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFish01.TabIndex = 8;
            this.ptbFish01.TabStop = false;
            // 
            // ptbFish07
            // 
            this.ptbFish07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbFish07.Image = global::game.Properties.Resources.fish07pointRight;
            this.ptbFish07.Location = new System.Drawing.Point(749, 3);
            this.ptbFish07.Name = "ptbFish07";
            this.ptbFish07.Size = new System.Drawing.Size(65, 47);
            this.ptbFish07.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFish07.TabIndex = 9;
            this.ptbFish07.TabStop = false;
            // 
            // ptbFish15
            // 
            this.ptbFish15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbFish15.Image = global::game.Properties.Resources.fish15pointRight;
            this.ptbFish15.Location = new System.Drawing.Point(820, 3);
            this.ptbFish15.Name = "ptbFish15";
            this.ptbFish15.Size = new System.Drawing.Size(65, 47);
            this.ptbFish15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFish15.TabIndex = 10;
            this.ptbFish15.TabStop = false;
            // 
            // ptbFish20
            // 
            this.ptbFish20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbFish20.Image = global::game.Properties.Resources.fish20pointRight;
            this.ptbFish20.Location = new System.Drawing.Point(891, 3);
            this.ptbFish20.Name = "ptbFish20";
            this.ptbFish20.Size = new System.Drawing.Size(65, 47);
            this.ptbFish20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFish20.TabIndex = 11;
            this.ptbFish20.TabStop = false;
            // 
            // ptbFish40
            // 
            this.ptbFish40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbFish40.Image = global::game.Properties.Resources.fish40pointRight;
            this.ptbFish40.Location = new System.Drawing.Point(963, 3);
            this.ptbFish40.Name = "ptbFish40";
            this.ptbFish40.Size = new System.Drawing.Size(65, 47);
            this.ptbFish40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFish40.TabIndex = 12;
            this.ptbFish40.TabStop = false;
            // 
            // lbGameOver
            // 
            this.lbGameOver.AutoSize = true;
            this.lbGameOver.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbGameOver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbGameOver.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameOver.ForeColor = System.Drawing.Color.Crimson;
            this.lbGameOver.Location = new System.Drawing.Point(254, 241);
            this.lbGameOver.Name = "lbGameOver";
            this.lbGameOver.Size = new System.Drawing.Size(465, 112);
            this.lbGameOver.TabIndex = 13;
            this.lbGameOver.Text = "GAME OVER";
            // 
            // ship
            // 
            this.ship.Image = global::game.Properties.Resources.ship;
            this.ship.Location = new System.Drawing.Point(3, 93);
            this.ship.Name = "ship";
            this.ship.Size = new System.Drawing.Size(172, 67);
            this.ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ship.TabIndex = 14;
            this.ship.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 549);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 18);
            this.panel1.TabIndex = 15;
            // 
            // timer_Heart
            // 
            this.timer_Heart.Enabled = true;
            this.timer_Heart.Interval = 30;
            this.timer_Heart.Tick += new System.EventHandler(this.timer_Heart_Tick);
            // 
            // timer_soundPlay
            // 
            this.timer_soundPlay.Enabled = true;
            this.timer_soundPlay.Interval = 30000;
            this.timer_soundPlay.Tick += new System.EventHandler(this.timer_soundPlay_Tick);
            // 
            // haveboom
            // 
            this.haveboom.AutoSize = true;
            this.haveboom.Location = new System.Drawing.Point(314, 20);
            this.haveboom.Name = "haveboom";
            this.haveboom.Size = new System.Drawing.Size(13, 13);
            this.haveboom.TabIndex = 16;
            this.haveboom.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbLevel);
            this.panel2.Controls.Add(this.ship);
            this.panel2.Controls.Add(this.ptbFish01);
            this.panel2.Controls.Add(this.lbHeart);
            this.panel2.Controls.Add(this.ptbFish40);
            this.panel2.Controls.Add(this.lbScore);
            this.panel2.Controls.Add(this.ptbFish20);
            this.panel2.Controls.Add(this.ptbFish07);
            this.panel2.Controls.Add(this.ptbFish15);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1033, 148);
            this.panel2.TabIndex = 17;
            // 
            // GAME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(191)))), ((int)(((byte)(246)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.haveboom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbGameOver);
            this.Controls.Add(this.pic04);
            this.Controls.Add(this.pic03);
            this.Controls.Add(this.pic01);
            this.Controls.Add(this.pic02);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.Name = "GAME";
            this.Text = "Cá ăn cá";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFish01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFish07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFish15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFish20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFish40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pic04;
        private System.Windows.Forms.Timer tmMain;
        private System.Windows.Forms.PictureBox pic02;
        private System.Windows.Forms.PictureBox pic01;
        private System.Windows.Forms.PictureBox pic03;
        private System.Windows.Forms.Label lbHeart;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.PictureBox ptbFish01;
        private System.Windows.Forms.PictureBox ptbFish07;
        private System.Windows.Forms.PictureBox ptbFish15;
        private System.Windows.Forms.PictureBox ptbFish20;
        private System.Windows.Forms.PictureBox ptbFish40;
        private System.Windows.Forms.Label lbGameOver;
        private System.Windows.Forms.PictureBox ship;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer_Heart;
        private System.Windows.Forms.Timer timer_soundPlay;
        private System.Windows.Forms.Label haveboom;
        private System.Windows.Forms.Panel panel2;
    }
}

