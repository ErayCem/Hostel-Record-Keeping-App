namespace AyÇiçeği_Pansiyon_Uygulaması_2
{
    partial class FrmRadyoDinle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRadyoDinle));
            this.Kanal1 = new System.Windows.Forms.LinkLabel();
            this.Kanal3 = new System.Windows.Forms.LinkLabel();
            this.Kanal2 = new System.Windows.Forms.LinkLabel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Kanal1
            // 
            this.Kanal1.AutoSize = true;
            this.Kanal1.BackColor = System.Drawing.SystemColors.Info;
            this.Kanal1.Font = new System.Drawing.Font("Segoe Script", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kanal1.LinkColor = System.Drawing.Color.Olive;
            this.Kanal1.Location = new System.Drawing.Point(229, 478);
            this.Kanal1.Name = "Kanal1";
            this.Kanal1.Size = new System.Drawing.Size(105, 38);
            this.Kanal1.TabIndex = 0;
            this.Kanal1.TabStop = true;
            this.Kanal1.Text = "Kanal1";
            this.Kanal1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Kanal1_LinkClicked);
            // 
            // Kanal3
            // 
            this.Kanal3.AutoSize = true;
            this.Kanal3.BackColor = System.Drawing.SystemColors.Info;
            this.Kanal3.Font = new System.Drawing.Font("Segoe Script", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kanal3.LinkColor = System.Drawing.Color.Olive;
            this.Kanal3.Location = new System.Drawing.Point(561, 478);
            this.Kanal3.Name = "Kanal3";
            this.Kanal3.Size = new System.Drawing.Size(105, 38);
            this.Kanal3.TabIndex = 1;
            this.Kanal3.TabStop = true;
            this.Kanal3.Text = "Kanal3";
            this.Kanal3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Kanal3_LinkClicked);
            // 
            // Kanal2
            // 
            this.Kanal2.AutoSize = true;
            this.Kanal2.BackColor = System.Drawing.SystemColors.Info;
            this.Kanal2.Font = new System.Drawing.Font("Segoe Script", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kanal2.LinkColor = System.Drawing.Color.Olive;
            this.Kanal2.Location = new System.Drawing.Point(393, 478);
            this.Kanal2.Name = "Kanal2";
            this.Kanal2.Size = new System.Drawing.Size(105, 38);
            this.Kanal2.TabIndex = 2;
            this.Kanal2.TabStop = true;
            this.Kanal2.Text = "Kanal2";
            this.Kanal2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Kanal2_LinkClicked);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(31, 31);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(593, 292);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // FrmRadyoDinle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 686);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.Kanal2);
            this.Controls.Add(this.Kanal3);
            this.Controls.Add(this.Kanal1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRadyoDinle";
            this.Text = "FrmRadyoDinle";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Kanal1;
        private System.Windows.Forms.LinkLabel Kanal3;
        private System.Windows.Forms.LinkLabel Kanal2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}