namespace game
{
    partial class START
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(START));
            this.button1 = new System.Windows.Forms.Button();
            this.bntRule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("VNI-Dur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(61, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntRule
            // 
            this.bntRule.BackColor = System.Drawing.Color.LightGreen;
            this.bntRule.FlatAppearance.BorderSize = 0;
            this.bntRule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bntRule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bntRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntRule.Font = new System.Drawing.Font("VNI-Dur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntRule.ForeColor = System.Drawing.Color.Maroon;
            this.bntRule.Location = new System.Drawing.Point(61, 220);
            this.bntRule.Name = "bntRule";
            this.bntRule.Size = new System.Drawing.Size(234, 74);
            this.bntRule.TabIndex = 1;
            this.bntRule.Text = "RULE";
            this.bntRule.UseVisualStyleBackColor = false;
            this.bntRule.Click += new System.EventHandler(this.bntRule_Click);
            // 
            // START
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(374, 444);
            this.Controls.Add(this.bntRule);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(390, 483);
            this.Name = "START";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "START";
            this.Load += new System.EventHandler(this.START_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntRule;
    }
}