namespace HostQuanLyDanhBa
{
    partial class HostQuanLyDanhBa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaseLocation = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.chkbShowMEX = new System.Windows.Forms.CheckBox();
            this.cbbEndPoints = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Location:";
            // 
            // txtBaseLocation
            // 
            this.txtBaseLocation.Location = new System.Drawing.Point(106, 19);
            this.txtBaseLocation.Name = "txtBaseLocation";
            this.txtBaseLocation.Size = new System.Drawing.Size(308, 20);
            this.txtBaseLocation.TabIndex = 1;
            this.txtBaseLocation.Text = "http://localhost:8080/QuanLyDanhBa";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(488, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 39);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chkbShowMEX
            // 
            this.chkbShowMEX.AutoSize = true;
            this.chkbShowMEX.Location = new System.Drawing.Point(106, 48);
            this.chkbShowMEX.Name = "chkbShowMEX";
            this.chkbShowMEX.Size = new System.Drawing.Size(15, 14);
            this.chkbShowMEX.TabIndex = 3;
            this.chkbShowMEX.UseVisualStyleBackColor = true;
            // 
            // cbbEndPoints
            // 
            this.cbbEndPoints.FormattingEnabled = true;
            this.cbbEndPoints.Location = new System.Drawing.Point(106, 70);
            this.cbbEndPoints.Name = "cbbEndPoints";
            this.cbbEndPoints.Size = new System.Drawing.Size(121, 21);
            this.cbbEndPoints.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Show MEX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "EndPoints:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(300, 70);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(114, 20);
            this.txtLocation.TabIndex = 7;
            this.txtLocation.Text = "QuanLyDanhBa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Location:";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(488, 70);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 39);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(488, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 39);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "SaveConfig";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // HostQuanLyDanhBa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 168);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbEndPoints);
            this.Controls.Add(this.chkbShowMEX);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtBaseLocation);
            this.Controls.Add(this.label1);
            this.Name = "HostQuanLyDanhBa";
            this.Text = "HostQuanLyDanhBa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaseLocation;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkbShowMEX;
        private System.Windows.Forms.ComboBox cbbEndPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSave;
    }
}