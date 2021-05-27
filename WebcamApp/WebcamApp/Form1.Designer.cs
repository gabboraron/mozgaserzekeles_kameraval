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
            this.picDiff = new System.Windows.Forms.PictureBox();
            this.textBoxDifference = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiff)).BeginInit();
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
            this.btnStart.Location = new System.Drawing.Point(1340, 447);
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
            // picDiff
            // 
            this.picDiff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDiff.Location = new System.Drawing.Point(975, 69);
            this.picDiff.Name = "picDiff";
            this.picDiff.Size = new System.Drawing.Size(474, 352);
            this.picDiff.TabIndex = 7;
            this.picDiff.TabStop = false;
            // 
            // textBoxDifference
            // 
            this.textBoxDifference.Location = new System.Drawing.Point(1103, 29);
            this.textBoxDifference.Multiline = true;
            this.textBoxDifference.Name = "textBoxDifference";
            this.textBoxDifference.Size = new System.Drawing.Size(346, 34);
            this.textBoxDifference.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(991, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "eltérés mértéke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "referencia kép";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1180, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "különbség";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "élő webkamera  kép";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 499);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDifference);
            this.Controls.Add(this.picDiff);
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
            ((System.ComponentModel.ISupportInitialize)(this.picDiff)).EndInit();
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
        private System.Windows.Forms.PictureBox picDiff;
        private System.Windows.Forms.TextBox textBoxDifference;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}