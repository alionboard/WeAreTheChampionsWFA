namespace WeAreTheChampions
{
    partial class ColorsForm
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
            this.lstColors = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSaveColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewColor = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gboColor = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gboColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstColors
            // 
            this.lstColors.DisplayMember = "ColorName";
            this.lstColors.FormattingEnabled = true;
            this.lstColors.ItemHeight = 14;
            this.lstColors.Location = new System.Drawing.Point(30, 38);
            this.lstColors.Name = "lstColors";
            this.lstColors.Size = new System.Drawing.Size(146, 172);
            this.lstColors.TabIndex = 0;
            this.lstColors.ValueMember = "Id";
            this.lstColors.SelectedIndexChanged += new System.EventHandler(this.lstColors_SelectedIndexChanged);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // btnSaveColor
            // 
            this.btnSaveColor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveColor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveColor.Location = new System.Drawing.Point(9, 55);
            this.btnSaveColor.Name = "btnSaveColor";
            this.btnSaveColor.Size = new System.Drawing.Size(59, 23);
            this.btnSaveColor.TabIndex = 1;
            this.btnSaveColor.Text = "Pick";
            this.btnSaveColor.UseVisualStyleBackColor = false;
            this.btnSaveColor.Click += new System.EventHandler(this.btnPickColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Colors";
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(186, 38);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(11, 172);
            this.lblColor.TabIndex = 6;
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(9, 29);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(128, 20);
            this.txtColorName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // btnNewColor
            // 
            this.btnNewColor.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNewColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewColor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewColor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewColor.Location = new System.Drawing.Point(30, 216);
            this.btnNewColor.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewColor.Name = "btnNewColor";
            this.btnNewColor.Size = new System.Drawing.Size(30, 23);
            this.btnNewColor.TabIndex = 11;
            this.btnNewColor.UseVisualStyleBackColor = false;
            this.btnNewColor.Click += new System.EventHandler(this.btnNewColor_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Maroon;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Location = new System.Drawing.Point(146, 216);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(30, 23);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gboColor
            // 
            this.gboColor.Controls.Add(this.btnCancel);
            this.gboColor.Controls.Add(this.txtColorName);
            this.gboColor.Controls.Add(this.btnSaveColor);
            this.gboColor.Controls.Add(this.label1);
            this.gboColor.Location = new System.Drawing.Point(30, 216);
            this.gboColor.Name = "gboColor";
            this.gboColor.Size = new System.Drawing.Size(146, 87);
            this.gboColor.TabIndex = 14;
            this.gboColor.TabStop = false;
            this.gboColor.Text = "New Color";
            this.gboColor.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(74, 55);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEdit.Location = new System.Drawing.Point(80, 216);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(47, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 305);
            this.Controls.Add(this.gboColor);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnNewColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstColors);
            this.Controls.Add(this.btnEdit);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(225, 344);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(225, 344);
            this.Name = "ColorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Colors";
            this.gboColor.ResumeLayout(false);
            this.gboColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstColors;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSaveColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewColor;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gboColor;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
    }
}