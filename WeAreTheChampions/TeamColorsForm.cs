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
    public partial class TeamColorsForm : Form
    {
        ChampionsContext db;
        Team selectedTeam;
        public TeamColorsForm(/*ChampionsContext db,*/ int teamId)
        {
            //this.db = db;
            db = new ChampionsContext();
            this.selectedTeam = db.Teams.Find(teamId);
            InitializeComponent();
            btnRemove.Text = "\u2796";
            btnNewColor.Text = "\u2795";
            lblTeamName.Text = selectedTeam.ShortName+" Colors";
            ListteamColors();
        }

        private void ListteamColors()
        {
            if (selectedTeam.Colors!=null)
            {
                var selectedList = selectedTeam.Colors.ToList();
                lstTeamColors.DataSource = selectedList.ToList();
                cboColors.DataSource = db.Colors.ToList().Where(c => !selectedList.Contains(c)).ToList();
            }
            else
            {
                cboColors.DataSource = db.Colors.ToList();
            }

            
        }

        private void lstTeamColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTeamColors.SelectedItems.Count < 1)
            {
                lblColor.BackColor = System.Drawing.SystemColors.Control;
                return;
            }
            var col = (Models.Color)lstTeamColors.SelectedItem;
            lblColor.BackColor = System.Drawing.Color.FromArgb(col.Red, col.Green, col.Blue);

        }

        private void btnNewColor_Click(object sender, EventArgs e)
        {
            if(cboColors.SelectedIndex<0)
            {
                return;
            }
            var col = (Models.Color)cboColors.SelectedItem;
            selectedTeam.Colors.Add(col);
            db.SaveChanges();
            ListteamColors();
            lstTeamColors.SelectedIndex = lstTeamColors.Items.Count - 1;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstTeamColors.SelectedItems.Count < 1)
            {
                lblColor.BackColor = System.Drawing.SystemColors.Control;
                return;
            }
            Models.Color color = (Models.Color)lstTeamColors.SelectedItem;
            selectedTeam.Colors.Remove(color);
            db.SaveChanges();
            ListteamColors();
            lblColor.BackColor = System.Drawing.SystemColors.Control;


        }
    }
}
