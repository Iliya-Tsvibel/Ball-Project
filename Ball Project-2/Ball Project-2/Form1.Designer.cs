namespace Ball_Project_2
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Moon = new System.Windows.Forms.PictureBox();
            this.GetBall = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // Moon
            // 
            this.Moon.Image = global::Ball_Project_2.Properties.Resources.kisspng_earth_supermoon_lunar_phase_moon_png_no_background_5ab035c9dc6088_6390594215214975459027;
            this.Moon.Location = new System.Drawing.Point(286, 281);
            this.Moon.Name = "Moon";
            this.Moon.Size = new System.Drawing.Size(158, 166);
            this.Moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Moon.TabIndex = 1;
            this.Moon.TabStop = false;
     
            // 
            // GetBall
            // 
            this.GetBall.Location = new System.Drawing.Point(12, 12);
            this.GetBall.Name = "GetBall";
            this.GetBall.Size = new System.Drawing.Size(245, 84);
            this.GetBall.TabIndex = 1;
            this.GetBall.Text = "Make Moon Faster";
            this.GetBall.UseVisualStyleBackColor = true;
            this.GetBall.Click += new System.EventHandler(this.Run_Moon_Faster);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClearAll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GetBall);
            this.Controls.Add(this.Moon);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Moon;
        private System.Windows.Forms.Button GetBall;
        private System.Windows.Forms.Button button1;
    }
}

