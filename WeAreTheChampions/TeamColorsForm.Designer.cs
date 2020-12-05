namespace WeAreTheChampions
{
    partial class TeamColorsForm
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
            if (disposing)
            {
                db.Dispose();
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
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lstTeamColors = new System.Windows.Forms.ListBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnNewColor = new System.Windows.Forms.Button();
            this.cboColors = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(23, 28);
            this.lblTeamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(87, 16);
            this.lblTeamName.TabIndex = 7;
            this.lblTeamName.Text = "Teams Colors";
            // 
            // lstTeamColors
            // 
            this.lstTeamColors.DisplayMember = "ColorName";
            this.lstTeamColors.FormattingEnabled = true;
            this.lstTeamColors.ItemHeight = 14;
            this.lstTeamColors.Location = new System.Drawing.Point(26, 46);
            this.lstTeamColors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstTeamColors.Name = "lstTeamColors";
            this.lstTeamColors.Size = new System.Drawing.Size(123, 172);
            this.lstTeamColors.TabIndex = 6;
            this.lstTeamColors.ValueMember = "Id";
            this.lstTeamColors.SelectedIndexChanged += new System.EventHandler(this.lstTeamColors_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(156, 46);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(11, 172);
            this.lblColor.TabIndex = 8;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Maroon;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Location = new System.Drawing.Point(124, 21);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(25, 23);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNewColor
            // 
            this.btnNewColor.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNewColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewColor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewColor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewColor.Location = new System.Drawing.Point(124, 245);
            this.btnNewColor.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewColor.Name = "btnNewColor";
            this.btnNewColor.Size = new System.Drawing.Size(25, 23);
            this.btnNewColor.TabIndex = 14;
            this.btnNewColor.UseVisualStyleBackColor = false;
            this.btnNewColor.Click += new System.EventHandler(this.btnNewColor_Click);
            // 
            // cboColors
            // 
            this.cboColors.DisplayMember = "ColorName";
            this.cboColors.DropDownHeight = 60;
            this.cboColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColors.FormattingEnabled = true;
            this.cboColors.IntegralHeight = false;
            this.cboColors.Location = new System.Drawing.Point(29, 245);
            this.cboColors.Name = "cboColors";
            this.cboColors.Size = new System.Drawing.Size(92, 22);
            this.cboColors.TabIndex = 16;
            this.cboColors.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "Add Color to Team";
            // 
            // TeamColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 276);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboColors);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnNewColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.lstTeamColors);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(195, 315);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(195, 315);
            this.Name = "TeamColorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Colors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.ListBox lstTeamColors;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNewColor;
        private System.Windows.Forms.ComboBox cboColors;
        private System.Windows.Forms.Label label2;
    }
}