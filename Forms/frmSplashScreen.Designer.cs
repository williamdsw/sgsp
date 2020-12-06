namespace SGSP___Desktop
{
    partial class frmSplashScreen
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
            this.tmrFadeIn = new System.Windows.Forms.Timer(this.components);
            this.tmrFadeOut = new System.Windows.Forms.Timer(this.components);
            this.ptbSplash = new System.Windows.Forms.PictureBox();
            this.pgbProgresso = new MetroFramework.Controls.MetroProgressBar();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrFadeIn
            // 
            this.tmrFadeIn.Tick += new System.EventHandler(this.tmrFadeIn_Tick);
            // 
            // tmrFadeOut
            // 
            this.tmrFadeOut.Tick += new System.EventHandler(this.tmrFadeOut_Tick);
            // 
            // ptbSplash
            // 
            this.ptbSplash.Image = global::SGSP___Desktop.Properties.Resources.png_sgsp_logo;
            this.ptbSplash.Location = new System.Drawing.Point(1, 2);
            this.ptbSplash.Name = "ptbSplash";
            this.ptbSplash.Size = new System.Drawing.Size(652, 339);
            this.ptbSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSplash.TabIndex = 0;
            this.ptbSplash.TabStop = false;
            // 
            // pgbProgresso
            // 
            this.pgbProgresso.Location = new System.Drawing.Point(82, 294);
            this.pgbProgresso.Name = "pgbProgresso";
            this.pgbProgresso.Size = new System.Drawing.Size(160, 33);
            this.pgbProgresso.Style = MetroFramework.MetroColorStyle.Lime;
            this.pgbProgresso.TabIndex = 2;
            this.pgbProgresso.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tmrTimer
            // 
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 339);
            this.Controls.Add(this.pgbProgresso);
            this.Controls.Add(this.ptbSplash);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrFadeIn;
        private System.Windows.Forms.Timer tmrFadeOut;
        private System.Windows.Forms.PictureBox ptbSplash;
        private MetroFramework.Controls.MetroProgressBar pgbProgresso;
        private System.Windows.Forms.Timer tmrTimer;
    }
}