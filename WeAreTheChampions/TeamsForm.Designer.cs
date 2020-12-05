namespace WeAreTheChampions
{
    partial class TeamsForm
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
            this.dgvTeams = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.btnSeeFreeAgents = new System.Windows.Forms.Button();
            this.btnAddToTeam = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnNewTeam = new System.Windows.Forms.Button();
            this.btnEditTeam = new System.Windows.Forms.Button();
            this.gboTeam = new System.Windows.Forms.GroupBox();
            this.btnDeleteTeam = new System.Windows.Forms.Button();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTeamColors = new System.Windows.Forms.Button();
            this.lblPlayerToTeam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).BeginInit();
            this.gboTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTeams
            // 
            this.dgvTeams.AllowUserToAddRows = false;
            this.dgvTeams.AllowUserToDeleteRows = false;
            this.dgvTeams.AllowUserToResizeColumns = false;
            this.dgvTeams.AllowUserToResizeRows = false;
            this.dgvTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeams.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTeams.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTeams.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvTeams.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTeams.Location = new System.Drawing.Point(50, 43);
            this.dgvTeams.MultiSelect = false;
            this.dgvTeams.Name = "dgvTeams";
            this.dgvTeams.ReadOnly = true;
            this.dgvTeams.RowHeadersVisible = false;
            this.dgvTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeams.Size = new System.Drawing.Size(325, 267);
            this.dgvTeams.TabIndex = 2;
            this.dgvTeams.SelectionChanged += new System.EventHandler(this.dgvTeams_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Id";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TeamName";
            this.Column2.HeaderText = "Full Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ShortName";
            this.Column3.FillWeight = 70F;
            this.Column3.HeaderText = "Short Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // lstPlayers
            // 
            this.lstPlayers.DisplayMember = "PlayerName";
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.ItemHeight = 14;
            this.lstPlayers.Location = new System.Drawing.Point(381, 43);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(132, 270);
            this.lstPlayers.TabIndex = 3;
            this.lstPlayers.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Teams";
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayers.Location = new System.Drawing.Point(403, 26);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(89, 16);
            this.lblPlayers.TabIndex = 6;
            this.lblPlayers.Text = "Team\'s Squad";
            // 
            // btnSeeFreeAgents
            // 
            this.btnSeeFreeAgents.BackColor = System.Drawing.Color.DimGray;
            this.btnSeeFreeAgents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeeFreeAgents.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeeFreeAgents.Location = new System.Drawing.Point(422, 319);
            this.btnSeeFreeAgents.Name = "btnSeeFreeAgents";
            this.btnSeeFreeAgents.Size = new System.Drawing.Size(91, 24);
            this.btnSeeFreeAgents.TabIndex = 8;
            this.btnSeeFreeAgents.Text = "Free Agents";
            this.btnSeeFreeAgents.UseVisualStyleBackColor = false;
            this.btnSeeFreeAgents.Click += new System.EventHandler(this.btnSeeFreeAgents_Click);
            // 
            // btnAddToTeam
            // 
            this.btnAddToTeam.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddToTeam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddToTeam.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToTeam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddToTeam.Location = new System.Drawing.Point(386, 319);
            this.btnAddToTeam.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddToTeam.Name = "btnAddToTeam";
            this.btnAddToTeam.Size = new System.Drawing.Size(30, 23);
            this.btnAddToTeam.TabIndex = 10;
            this.btnAddToTeam.UseVisualStyleBackColor = false;
            this.btnAddToTeam.Visible = false;
            this.btnAddToTeam.Click += new System.EventHandler(this.btnAddToTeam_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(438, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Maroon;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Location = new System.Drawing.Point(386, 319);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(30, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNewTeam
            // 
            this.btnNewTeam.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNewTeam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewTeam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewTeam.Location = new System.Drawing.Point(50, 318);
            this.btnNewTeam.Name = "btnNewTeam";
            this.btnNewTeam.Size = new System.Drawing.Size(74, 24);
            this.btnNewTeam.TabIndex = 13;
            this.btnNewTeam.Text = "New Team";
            this.btnNewTeam.UseVisualStyleBackColor = false;
            this.btnNewTeam.Click += new System.EventHandler(this.btnNewTeam_Click);
            // 
            // btnEditTeam
            // 
            this.btnEditTeam.BackColor = System.Drawing.Color.Gold;
            this.btnEditTeam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditTeam.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEditTeam.Location = new System.Drawing.Point(130, 318);
            this.btnEditTeam.Name = "btnEditTeam";
            this.btnEditTeam.Size = new System.Drawing.Size(74, 24);
            this.btnEditTeam.TabIndex = 14;
            this.btnEditTeam.Text = "Edit Team";
            this.btnEditTeam.UseVisualStyleBackColor = false;
            this.btnEditTeam.Click += new System.EventHandler(this.btnEditTeam_Click);
            // 
            // gboTeam
            // 
            this.gboTeam.Controls.Add(this.btnDeleteTeam);
            this.gboTeam.Controls.Add(this.txtShortName);
            this.gboTeam.Controls.Add(this.label2);
            this.gboTeam.Controls.Add(this.btnCancelEdit);
            this.gboTeam.Controls.Add(this.btnAddSave);
            this.gboTeam.Controls.Add(this.txtFullName);
            this.gboTeam.Controls.Add(this.label4);
            this.gboTeam.Location = new System.Drawing.Point(50, 318);
            this.gboTeam.Name = "gboTeam";
            this.gboTeam.Size = new System.Drawing.Size(463, 76);
            this.gboTeam.TabIndex = 15;
            this.gboTeam.TabStop = false;
            this.gboTeam.Text = "Edit Team";
            this.gboTeam.Visible = false;
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteTeam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteTeam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteTeam.Location = new System.Drawing.Point(394, 23);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(63, 44);
            this.btnDeleteTeam.TabIndex = 17;
            this.btnDeleteTeam.Text = "Delete Team";
            this.btnDeleteTeam.UseVisualStyleBackColor = false;
            this.btnDeleteTeam.Click += new System.EventHandler(this.btnDeleteTeam_Click);
            // 
            // txtShortName
            // 
            this.txtShortName.Location = new System.Drawing.Point(80, 50);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(60, 20);
            this.txtShortName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = "Short Name";
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelEdit.Location = new System.Drawing.Point(298, 24);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(63, 23);
            this.btnCancelEdit.TabIndex = 14;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnAddSave
            // 
            this.btnAddSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddSave.Location = new System.Drawing.Point(229, 24);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(63, 23);
            this.btnAddSave.TabIndex = 12;
            this.btnAddSave.Text = "Save";
            this.btnAddSave.UseVisualStyleBackColor = false;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(80, 24);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(121, 20);
            this.txtFullName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Full Name";
            // 
            // btnTeamColors
            // 
            this.btnTeamColors.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnTeamColors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeamColors.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTeamColors.Location = new System.Drawing.Point(210, 318);
            this.btnTeamColors.Name = "btnTeamColors";
            this.btnTeamColors.Size = new System.Drawing.Size(132, 24);
            this.btnTeamColors.TabIndex = 16;
            this.btnTeamColors.Text = "Selected Team\'s Colors";
            this.btnTeamColors.UseVisualStyleBackColor = false;
            this.btnTeamColors.Click += new System.EventHandler(this.btnTeamColors_Click);
            // 
            // lblPlayerToTeam
            // 
            this.lblPlayerToTeam.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerToTeam.Location = new System.Drawing.Point(377, 342);
            this.lblPlayerToTeam.Name = "lblPlayerToTeam";
            this.lblPlayerToTeam.Size = new System.Drawing.Size(49, 14);
            this.lblPlayerToTeam.TabIndex = 0;
            this.lblPlayerToTeam.Text = "Player";
            this.lblPlayerToTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 405);
            this.Controls.Add(this.gboTeam);
            this.Controls.Add(this.btnEditTeam);
            this.Controls.Add(this.btnNewTeam);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSeeFreeAgents);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPlayers);
            this.Controls.Add(this.dgvTeams);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddToTeam);
            this.Controls.Add(this.btnTeamColors);
            this.Controls.Add(this.lblPlayerToTeam);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(571, 444);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(571, 434);
            this.Name = "TeamsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teams";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).EndInit();
            this.gboTeam.ResumeLayout(false);
            this.gboTeam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeams;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Button btnSeeFreeAgents;
        private System.Windows.Forms.Button btnAddToTeam;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNewTeam;
        private System.Windows.Forms.Button btnEditTeam;
        private System.Windows.Forms.GroupBox gboTeam;
        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnTeamColors;
        private System.Windows.Forms.Label lblPlayerToTeam;
    }
}