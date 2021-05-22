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
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCamera
            // 
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(98, 26);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(391, 24);
            this.cboCamera.TabIndex = 0;
            // 
            // Camera
            // 
            this.Camera.AutoSize = true;
            this.Camera.Location = new System.Drawing.Point(12, 29);
            this.Camera.Name = "Camera";
            this.Camera.Size = new System.Drawing.Size(57, 17);
            this.Camera.TabIndex = 1;
            this.Camera.Text = "Kamera";
            this.Camera.Click += new System.EventHandler(this.label1_Click);
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(15, 69);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(474, 352);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(386, 427);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start/Stop";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 457);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.Camera);
            this.Controls.Add(this.cboCamera);
            this.Name = "Form1";
            this.Text = "WebCam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Label Camera;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnStart;
    }
}

