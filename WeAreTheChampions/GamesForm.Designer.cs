namespace WeAreTheChampions
{
    partial class GamesForm
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
            this.cboTeam1 = new System.Windows.Forms.ComboBox();
            this.cboTeam2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTeam1Score = new System.Windows.Forms.TextBox();
            this.lblSeperator = new System.Windows.Forms.Label();
            this.chkGameStatus = new System.Windows.Forms.CheckBox();
            this.txtTeam2Score = new System.Windows.Forms.TextBox();
            this.lblScores = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboTeam1
            // 
            this.cboTeam1.DisplayMember = "TeamName";
            this.cboTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeam1.FormattingEnabled = true;
            this.cboTeam1.Location = new System.Drawing.Point(14, 31);
            this.cboTeam1.Name = "cboTeam1";
            this.cboTeam1.Size = new System.Drawing.Size(121, 22);
            this.cboTeam1.TabIndex = 0;
            this.cboTeam1.ValueMember = "Id";
            // 
            // cboTeam2
            // 
            this.cboTeam2.DisplayMember = "TeamName";
            this.cboTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeam2.FormattingEnabled = true;
            this.cboTeam2.Location = new System.Drawing.Point(156, 31);
            this.cboTeam2.Name = "cboTeam2";
            this.cboTeam2.Size = new System.Drawing.Size(121, 22);
            this.cboTeam2.TabIndex = 1;
            this.cboTeam2.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Home Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Away Team";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(419, 33);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(54, 20);
            this.dtpTime.TabIndex = 11;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(302, 33);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(94, 20);
            this.dtpDate.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Time";
            // 
            // txtTeam1Score
            // 
            this.txtTeam1Score.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeam1Score.Location = new System.Drawing.Point(40, 67);
            this.txtTeam1Score.Name = "txtTeam1Score";
            this.txtTeam1Score.Size = new System.Drawing.Size(62, 39);
            this.txtTeam1Score.TabIndex = 14;
            this.txtTeam1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTeam1Score.Visible = false;
            // 
            // lblSeperator
            // 
            this.lblSeperator.AutoSize = true;
            this.lblSeperator.Location = new System.Drawing.Point(140, 85);
            this.lblSeperator.Name = "lblSeperator";
            this.lblSeperator.Size = new System.Drawing.Size(11, 14);
            this.lblSeperator.TabIndex = 19;
            this.lblSeperator.Text = "-";
            this.lblSeperator.Visible = false;
            // 
            // chkGameStatus
            // 
            this.chkGameStatus.AutoSize = true;
            this.chkGameStatus.Location = new System.Drawing.Point(501, 35);
            this.chkGameStatus.Name = "chkGameStatus";
            this.chkGameStatus.Size = new System.Drawing.Size(107, 18);
            this.chkGameStatus.TabIndex = 20;
            this.chkGameStatus.Text = "Game Completed";
            this.chkGameStatus.UseVisualStyleBackColor = true;
            this.chkGameStatus.CheckedChanged += new System.EventHandler(this.chkGameStatus_CheckedChanged);
            // 
            // txtTeam2Score
            // 
            this.txtTeam2Score.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeam2Score.Location = new System.Drawing.Point(186, 67);
            this.txtTeam2Score.Name = "txtTeam2Score";
            this.txtTeam2Score.Size = new System.Drawing.Size(62, 39);
            this.txtTeam2Score.TabIndex = 21;
            this.txtTeam2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTeam2Score.Visible = false;
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Location = new System.Drawing.Point(123, 71);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(42, 14);
            this.lblScores.TabIndex = 22;
            this.lblScores.Text = "Scores";
            this.lblScores.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(444, 91);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(525, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 125);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.txtTeam2Score);
            this.Controls.Add(this.chkGameStatus);
            this.Controls.Add(this.lblSeperator);
            this.Controls.Add(this.txtTeam1Score);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTeam2);
            this.Controls.Add(this.cboTeam1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(628, 164);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(628, 164);
            this.Name = "GamesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTeam1;
        private System.Windows.Forms.ComboBox cboTeam2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTeam1Score;
        private System.Windows.Forms.Label lblSeperator;
        private System.Windows.Forms.CheckBox chkGameStatus;
        private System.Windows.Forms.TextBox txtTeam2Score;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}