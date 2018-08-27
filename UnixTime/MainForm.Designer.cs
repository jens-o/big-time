namespace AllTime
{
    partial class MainForm
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
            this.lblCurrentUnixTime = new System.Windows.Forms.Label();
            this.bgwTime = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentUtcTime = new System.Windows.Forms.Label();
            this.lblInternetTime = new System.Windows.Forms.Label();
            this.txtUnixTime = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtUtcTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLocalTime = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInternetTime = new System.Windows.Forms.TextBox();
            this.cboTimeZone = new System.Windows.Forms.ComboBox();
            this.txtCustomTime = new System.Windows.Forms.TextBox();
            this.lblUtc = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblCustom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCurrentUnixTime
            // 
            this.lblCurrentUnixTime.AutoSize = true;
            this.lblCurrentUnixTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUnixTime.Location = new System.Drawing.Point(144, 11);
            this.lblCurrentUnixTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentUnixTime.Name = "lblCurrentUnixTime";
            this.lblCurrentUnixTime.Size = new System.Drawing.Size(185, 36);
            this.lblCurrentUnixTime.TabIndex = 0;
            this.lblCurrentUnixTime.Text = "8888888888";
            // 
            // bgwTime
            // 
            this.bgwTime.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwTime_DoWork);
            this.bgwTime.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwTime_ProgressChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOW:";
            // 
            // lblCurrentUtcTime
            // 
            this.lblCurrentUtcTime.AutoSize = true;
            this.lblCurrentUtcTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUtcTime.Location = new System.Drawing.Point(415, 11);
            this.lblCurrentUtcTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentUtcTime.Name = "lblCurrentUtcTime";
            this.lblCurrentUtcTime.Size = new System.Drawing.Size(321, 36);
            this.lblCurrentUtcTime.TabIndex = 2;
            this.lblCurrentUtcTime.Text = "yyyy-MM-dd HH:mm:ss";
            // 
            // lblInternetTime
            // 
            this.lblInternetTime.AutoSize = true;
            this.lblInternetTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternetTime.Location = new System.Drawing.Point(821, 9);
            this.lblInternetTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInternetTime.Name = "lblInternetTime";
            this.lblInternetTime.Size = new System.Drawing.Size(96, 36);
            this.lblInternetTime.TabIndex = 3;
            this.lblInternetTime.Text = "@000";
            // 
            // txtUnixTime
            // 
            this.txtUnixTime.Location = new System.Drawing.Point(19, 191);
            this.txtUnixTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnixTime.Name = "txtUnixTime";
            this.txtUnixTime.Size = new System.Drawing.Size(223, 22);
            this.txtUnixTime.TabIndex = 4;
            this.txtUnixTime.Leave += new System.EventHandler(this.txtUnixTime_Leave);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(19, 257);
            this.btnGet.Margin = new System.Windows.Forms.Padding(4);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(100, 28);
            this.btnGet.TabIndex = 5;
            this.btnGet.Text = "NOW";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtUtcTime
            // 
            this.txtUtcTime.Location = new System.Drawing.Point(250, 191);
            this.txtUtcTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtUtcTime.Name = "txtUtcTime";
            this.txtUtcTime.Size = new System.Drawing.Size(162, 22);
            this.txtUtcTime.TabIndex = 7;
            this.txtUtcTime.Leave += new System.EventHandler(this.txtTime_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "UNIX Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "UTC Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Local Time";
            // 
            // txtLocalTime
            // 
            this.txtLocalTime.Location = new System.Drawing.Point(481, 191);
            this.txtLocalTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalTime.Name = "txtLocalTime";
            this.txtLocalTime.Size = new System.Drawing.Size(162, 22);
            this.txtLocalTime.TabIndex = 11;
            this.txtLocalTime.Leave += new System.EventHandler(this.txtLocalTime_Leave);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(19, 221);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(1034, 28);
            this.btnConvert.TabIndex = 13;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Internet Time";
            // 
            // txtInternetTime
            // 
            this.txtInternetTime.Location = new System.Drawing.Point(19, 133);
            this.txtInternetTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtInternetTime.Name = "txtInternetTime";
            this.txtInternetTime.Size = new System.Drawing.Size(105, 22);
            this.txtInternetTime.TabIndex = 14;
            this.txtInternetTime.Leave += new System.EventHandler(this.txtInternetTime_Leave);
            // 
            // cboTimeZone
            // 
            this.cboTimeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeZone.FormattingEnabled = true;
            this.cboTimeZone.Location = new System.Drawing.Point(712, 160);
            this.cboTimeZone.Name = "cboTimeZone";
            this.cboTimeZone.Size = new System.Drawing.Size(223, 24);
            this.cboTimeZone.TabIndex = 16;
            this.cboTimeZone.SelectedIndexChanged += new System.EventHandler(this.cboTimeZone_SelectedIndexChanged);
            // 
            // txtCustomTime
            // 
            this.txtCustomTime.Location = new System.Drawing.Point(712, 191);
            this.txtCustomTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomTime.Name = "txtCustomTime";
            this.txtCustomTime.Size = new System.Drawing.Size(162, 22);
            this.txtCustomTime.TabIndex = 17;
            this.txtCustomTime.Leave += new System.EventHandler(this.txtCustomTime_Leave);
            // 
            // lblUtc
            // 
            this.lblUtc.AutoSize = true;
            this.lblUtc.Location = new System.Drawing.Point(418, 194);
            this.lblUtc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUtc.Name = "lblUtc";
            this.lblUtc.Size = new System.Drawing.Size(36, 16);
            this.lblUtc.TabIndex = 18;
            this.lblUtc.Text = "UTC";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(651, 194);
            this.lblLocal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(0, 16);
            this.lblLocal.TabIndex = 19;
            // 
            // lblCustom
            // 
            this.lblCustom.AutoSize = true;
            this.lblCustom.Location = new System.Drawing.Point(882, 194);
            this.lblCustom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(0, 16);
            this.lblCustom.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 305);
            this.Controls.Add(this.lblCustom);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.lblUtc);
            this.Controls.Add(this.txtCustomTime);
            this.Controls.Add(this.cboTimeZone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInternetTime);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLocalTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUtcTime);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtUnixTime);
            this.Controls.Add(this.lblInternetTime);
            this.Controls.Add(this.lblCurrentUtcTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurrentUnixTime);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Local Time";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentUnixTime;
        private System.ComponentModel.BackgroundWorker bgwTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentUtcTime;
        private System.Windows.Forms.Label lblInternetTime;
        private System.Windows.Forms.TextBox txtUnixTime;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtUtcTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLocalTime;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInternetTime;
        private System.Windows.Forms.ComboBox cboTimeZone;
        private System.Windows.Forms.TextBox txtCustomTime;
        private System.Windows.Forms.Label lblUtc;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblCustom;
    }
}

