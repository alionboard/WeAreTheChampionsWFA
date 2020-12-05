using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Models;

namespace WeAreTheChampions
{
    public partial class ColorsForm : Form
    {
        ChampionsContext db;
        public ColorsForm(ChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            btnRemove.Text = "\u2796";
            btnNewColor.Text = "\u2795";
            ListColors();
        }

        private void ListColors()
        {
            lstColors.DataSource = db.Colors.ToList();
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            if (txtColorName.Text.Trim() == "")
            {
                MessageBox.Show("You must enter color name!");
                return;
            }

            ColorDialog cd = new ColorDialog();
            DialogResult result = cd.ShowDialog();
            int index;
            if (result == DialogResult.OK)
            {
                System.Drawing.Color pickedColor = cd.Color;

                if (gboColor.Text == "New Color")
                {
                    if (db.Colors.Any(x => x.ColorName == txtColorName.Text.Trim()))
                    {
                        MessageBox.Show("This name is already exists!");
                        ResetVisibles();
                        return;
                    }
                    Models.Color color = new Models.Color { ColorName = txtColorName.Text.Trim(), Red = pickedColor.R, Green = pickedColor.G, Blue = pickedColor.B };
                    db.Colors.Add(color);
                    index = lstColors.Items.Count;

                }
                else
                {
                    if (lstColors.SelectedItems.Count < 1)
                        return;


                    var col = (Models.Color)lstColors.SelectedItem;
                    col.ColorName = txtColorName.Text.Trim();
                    col.Red = pickedColor.R;
                    col.Green = pickedColor.G;
                    col.Blue = pickedColor.B;
                    index = lstColors.SelectedIndex;


                }
                db.SaveChanges();
                ListColors();
                lstColors.SetSelected(index, true);
            }


            gboColor.Text = "New Color";
            ResetVisibles();


        }

        private void ResetVisibles()
        {
            gboColor.Visible = false;
            btnNewColor.Visible = true;
            btnEdit.Visible = true;
            btnRemove.Visible = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstColors.SelectedItems.Count < 1)
                return;
            int index = lstColors.SelectedIndex;
            db.Colors.Remove((Models.Color)lstColors.SelectedItem);
            db.SaveChanges();
            ListColors();
            if (lstColors.SelectedItems.Count < 1)
            {
                lblColor.BackColor = System.Drawing.SystemColors.Control;
                return;
            }

            else if (index > lstColors.SelectedItems.Count)
                lstColors.SelectedIndex = index - 1;
            else
                lstColors.SelectedIndex = index;


        }

        private void lstColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstColors.SelectedItems.Count < 1)
            {
                lblColor.BackColor = System.Drawing.SystemColors.Control;
                return;
            }
            var col = (Models.Color)lstColors.SelectedItem;
            lblColor.BackColor = System.Drawing.Color.FromArgb(col.Red, col.Green, col.Blue);
        }

        private void btnNewColor_Click(object sender, EventArgs e)
        {
            gboColor.Visible = true;
            btnNewColor.Visible = false;
            btnEdit.Visible = false;
            btnRemove.Visible = false;
            txtColorName.Clear();

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetVisibles();
            gboColor.Text = "New Color";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstColors.SelectedItems.Count < 1)
            {
                return;
            }
            gboColor.Text = "Edit Color";
            gboColor.Visible = true;
            btnNewColor.Visible = false;
            btnEdit.Visible = false;
            btnRemove.Visible = false;
            var col = (Models.Color)lstColors.SelectedItem;
            txtColorName.Text = col.ColorName;
        }


    }
}
