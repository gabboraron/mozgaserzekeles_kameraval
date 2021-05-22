namespace WebcamApp
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
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.Camera = new System.Windows.Forms.Label();
            this.picOld = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.picNew = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNew)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCamera
            // 
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(134, 29);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(355, 24);
            this.cboCamera.TabIndex = 0;
            this.cboCamera.SelectedIndexChanged += new System.EventHandler(this.cboCamera_SelectedIndexChanged);
            // 
            // Camera
            // 
            this.Camera.AutoSize = true;
            this.Camera.Location = new System.Drawing.Point(12, 29);
            this.Camera.Name = "Camera";
            this.Camera.Size = new System.Drawing.Size(116, 17);
            this.Camera.TabIndex = 1;
            this.Camera.Text = "Kameraválasztás";
            this.Camera.Click += new System.EventHandler(this.label1_Click);
            // 
            // picOld
            // 
            this.picOld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOld.Location = new System.Drawing.Point(15, 69);
            this.picOld.Name = "picOld";
            this.picOld.Size = new System.Drawing.Size(474, 352);
            this.picOld.TabIndex = 2;
            this.picOld.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(856, 442);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 44);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start/Stop";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picNew
            // 
            this.picNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNew.Location = new System.Drawing.Point(495, 69);
            this.picNew.Name = "picNew";
            this.picNew.Size = new System.Drawing.Size(474, 352);
            this.picNew.TabIndex = 4;
            this.picNew.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Két kép közti idő másodpercben";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(228, 469);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(33, 22);
            this.time.TabIndex = 6;
            this.time.Text = "2";
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 499);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picNew);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picOld);
            this.Controls.Add(this.Camera);
            this.Controls.Add(this.cboCamera);
            this.Name = "Form1";
            this.Text = "WebCam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Label Camera;
        private System.Windows.Forms.PictureBox picOld;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox time;
    }
}

