namespace WeAreTheChampions
{
    partial class PlayersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboNewTeams = new System.Windows.Forms.ComboBox();
            this.txtNewPlayerName = new System.Windows.Forms.TextBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnEditPlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkNewPlayer = new System.Windows.Forms.CheckBox();
            this.gboNewPlayer = new System.Windows.Forms.GroupBox();
            this.btnCancelNew = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.gboEditPlayer = new System.Windows.Forms.GroupBox();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.cboEditTeams = new System.Windows.Forms.ComboBox();
            this.chkEditPlayer = new System.Windows.Forms.CheckBox();
            this.txtEditPlayerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboFilterTeams = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.gboNewPlayer.SuspendLayout();
            this.gboEditPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.AllowUserToResizeColumns = false;
            this.dgvPlayers.AllowUserToResizeRows = false;
            this.dgvPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlayers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(14, 2, 2, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlayers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlayers.Location = new System.Drawing.Point(12, 44);
            this.dgvPlayers.MultiSelect = false;
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlayers.RowHeadersVisible = false;
            this.dgvPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayers.Size = new System.Drawing.Size(439, 267);
            this.dgvPlayers.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Id";
            this.Column1.FillWeight = 30F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Team";
            this.Column3.HeaderText = "Team";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // cboNewTeams
            // 
            this.cboNewTeams.DisplayMember = "TeamName";
            this.cboNewTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewTeams.FormattingEnabled = true;
            this.cboNewTeams.Location = new System.Drawing.Point(214, 35);
            this.cboNewTeams.Name = "cboNewTeams";
            this.cboNewTeams.Size = new System.Drawing.Size(121, 22);
            this.cboNewTeams.TabIndex = 4;
            this.cboNewTeams.ValueMember = "Id";
            // 
            // txtNewPlayerName
            // 
            this.txtNewPlayerName.Location = new System.Drawing.Point(74, 35);
            this.txtNewPlayerName.Name = "txtNewPlayerName";
            this.txtNewPlayerName.Size = new System.Drawing.Size(121, 20);
            this.txtNewPlayerName.TabIndex = 5;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPlayer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddPlayer.Location = new System.Drawing.Point(252, 337);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(100, 23);
            this.btnAddPlayer.TabIndex = 6;
            this.btnAddPlayer.Text = "Add  New Player";
            this.btnAddPlayer.UseVisualStyleBackColor = false;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnEditPlayer
            // 
            this.btnEditPlayer.BackColor = System.Drawing.Color.Gold;
            this.btnEditPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditPlayer.Location = new System.Drawing.Point(12, 337);
            this.btnEditPlayer.Name = "btnEditPlayer";
            this.btnEditPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnEditPlayer.TabIndex = 7;
            this.btnEditPlayer.Text = "Edit Player";
            this.btnEditPlayer.UseVisualStyleBackColor = false;
            this.btnEditPlayer.Click += new System.EventHandler(this.btnEditPlayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Team";
            // 
            // chkNewPlayer
            // 
            this.chkNewPlayer.AutoSize = true;
            this.chkNewPlayer.Location = new System.Drawing.Point(256, 63);
            this.chkNewPlayer.Name = "chkNewPlayer";
            this.chkNewPlayer.Size = new System.Drawing.Size(79, 18);
            this.chkNewPlayer.TabIndex = 10;
            this.chkNewPlayer.Text = "Free Agent";
            this.chkNewPlayer.UseVisualStyleBackColor = true;
            this.chkNewPlayer.CheckedChanged += new System.EventHandler(this.chkNewPlayer_CheckedChanged);
            // 
            // gboNewPlayer
            // 
            this.gboNewPlayer.Controls.Add(this.btnCancelNew);
            this.gboNewPlayer.Controls.Add(this.btnAddNew);
            this.gboNewPlayer.Controls.Add(this.cboNewTeams);
            this.gboNewPlayer.Controls.Add(this.chkNewPlayer);
            this.gboNewPlayer.Controls.Add(this.txtNewPlayerName);
            this.gboNewPlayer.Controls.Add(this.label2);
            this.gboNewPlayer.Controls.Add(this.label1);
            this.gboNewPlayer.Location = new System.Drawing.Point(30, 317);
            this.gboNewPlayer.Name = "gboNewPlayer";
            this.gboNewPlayer.Size = new System.Drawing.Size(400, 109);
            this.gboNewPlayer.TabIndex = 11;
            this.gboNewPlayer.TabStop = false;
            this.gboNewPlayer.Text = "New Player";
            this.gboNewPlayer.Visible = false;
            // 
            // btnCancelNew
            // 
            this.btnCancelNew.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCancelNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelNew.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelNew.Location = new System.Drawing.Point(93, 77);
            this.btnCancelNew.Name = "btnCancelNew";
            this.btnCancelNew.Size = new System.Drawing.Size(75, 23);
            this.btnCancelNew.TabIndex = 13;
            this.btnCancelNew.Text = "Cancel";
            this.btnCancelNew.UseVisualStyleBackColor = false;
            this.btnCancelNew.Click += new System.EventHandler(this.btnCancelNew_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddNew.Location = new System.Drawing.Point(6, 77);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 12;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // gboEditPlayer
            // 
            this.gboEditPlayer.Controls.Add(this.btnCancelEdit);
            this.gboEditPlayer.Controls.Add(this.btnFinish);
            this.gboEditPlayer.Controls.Add(this.cboEditTeams);
            this.gboEditPlayer.Controls.Add(this.chkEditPlayer);
            this.gboEditPlayer.Controls.Add(this.txtEditPlayerName);
            this.gboEditPlayer.Controls.Add(this.label3);
            this.gboEditPlayer.Controls.Add(this.label4);
            this.gboEditPlayer.Location = new System.Drawing.Point(30, 317);
            this.gboEditPlayer.Name = "gboEditPlayer";
            this.gboEditPlayer.Size = new System.Drawing.Size(400, 109);
            this.gboEditPlayer.TabIndex = 13;
            this.gboEditPlayer.TabStop = false;
            this.gboEditPlayer.Text = "Edit Player";
            this.gboEditPlayer.Visible = false;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelEdit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelEdit.Location = new System.Drawing.Point(93, 77);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCancelEdit.TabIndex = 14;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinish.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFinish.Location = new System.Drawing.Point(6, 77);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 12;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // cboEditTeams
            // 
            this.cboEditTeams.DisplayMember = "TeamName";
            this.cboEditTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditTeams.FormattingEnabled = true;
            this.cboEditTeams.Location = new System.Drawing.Point(214, 35);
            this.cboEditTeams.Name = "cboEditTeams";
            this.cboEditTeams.Size = new System.Drawing.Size(121, 22);
            this.cboEditTeams.TabIndex = 4;
            this.cboEditTeams.ValueMember = "Id";
            // 
            // chkEditPlayer
            // 
            this.chkEditPlayer.AutoSize = true;
            this.chkEditPlayer.Location = new System.Drawing.Point(256, 63);
            this.chkEditPlayer.Name = "chkEditPlayer";
            this.chkEditPlayer.Size = new System.Drawing.Size(79, 18);
            this.chkEditPlayer.TabIndex = 10;
            this.chkEditPlayer.Text = "Free Agent";
            this.chkEditPlayer.UseVisualStyleBackColor = true;
            this.chkEditPlayer.CheckedChanged += new System.EventHandler(this.chkEditPlayer_CheckedChanged);
            // 
            // txtEditPlayerName
            // 
            this.txtEditPlayerName.Location = new System.Drawing.Point(74, 35);
            this.txtEditPlayerName.Name = "txtEditPlayerName";
            this.txtEditPlayerName.Size = new System.Drawing.Size(121, 20);
            this.txtEditPlayerName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.BackColor = System.Drawing.Color.Maroon;
            this.btnDeletePlayer.FlatAppearance.BorderSize = 0;
            this.btnDeletePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletePlayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeletePlayer.Location = new System.Drawing.Point(358, 337);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(93, 23);
            this.btnDeletePlayer.TabIndex = 15;
            this.btnDeletePlayer.Text = "Delete Player";
            this.btnDeletePlayer.UseVisualStyleBackColor = false;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Players";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 14);
            this.label6.TabIndex = 16;
            this.label6.Text = "Filter by";
            // 
            // cboFilterTeams
            // 
            this.cboFilterTeams.DisplayMember = "TeamName";
            this.cboFilterTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterTeams.FormattingEnabled = true;
            this.cboFilterTeams.Location = new System.Drawing.Point(330, 19);
            this.cboFilterTeams.Name = "cboFilterTeams";
            this.cboFilterTeams.Size = new System.Drawing.Size(121, 22);
            this.cboFilterTeams.TabIndex = 17;
            this.cboFilterTeams.ValueMember = "Id";
            this.cboFilterTeams.SelectedIndexChanged += new System.EventHandler(this.cboFilterTeams_SelectedIndexChanged);
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 430);
            this.Controls.Add(this.cboFilterTeams);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.gboEditPlayer);
            this.Controls.Add(this.btnEditPlayer);
            this.Controls.Add(this.btnDeletePlayer);
            this.Controls.Add(this.gboNewPlayer);
            this.Controls.Add(this.btnAddPlayer);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(485, 469);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(485, 469);
            this.Name = "PlayersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Players";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.gboNewPlayer.ResumeLayout(false);
            this.gboNewPlayer.PerformLayout();
            this.gboEditPlayer.ResumeLayout(false);
            this.gboEditPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.ComboBox cboNewTeams;
        private System.Windows.Forms.TextBox txtNewPlayerName;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnEditPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkNewPlayer;
        private System.Windows.Forms.GroupBox gboNewPlayer;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.GroupBox gboEditPlayer;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ComboBox cboEditTeams;
        private System.Windows.Forms.CheckBox chkEditPlayer;
        private System.Windows.Forms.TextBox txtEditPlayerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelNew;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboFilterTeams;
    }
}