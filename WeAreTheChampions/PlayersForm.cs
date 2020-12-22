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
    public partial class PlayersForm : Form
    {
        ChampionsContext db;
        public PlayersForm(ChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            ListPlayers();
            cboEditTeams.DataSource = cboNewTeams.DataSource = db.Teams.ToList();
            
            ListFilterTeams();
        }

        private void ListFilterTeams()
        {
            var filterTeams = db.Teams.ToList();
            filterTeams.Insert(0, new Team { TeamName = "All", ShortName = "All" });
            int count = filterTeams.Count;
            filterTeams.Add( new Team { TeamName = "Free Agents", ShortName = "Free" });;
            cboFilterTeams.DataSource = filterTeams;
        }

        private void ListPlayers()
        {
            dgvPlayers.DataSource = db.Players.ToList().Select(x => new
            {
                Id = x.Id,
                Name = x.PlayerName,
                Team = x.TeamId != null ? x.Team.TeamName : null
            }).ToList();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            gboNewPlayer.Visible = true;
            btnAddPlayer.Visible = false;
            btnEditPlayer.Visible = false;
            btnDeletePlayer.Visible = false;
        }

        private void btnEditPlayer_Click(object sender, EventArgs e)
        {
            if (dgvPlayers.SelectedRows.Count < 1)
            {
                MessageBox.Show("You must choose player to Edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            gboEditPlayer.Visible = true;
            btnAddPlayer.Visible = false;
            btnEditPlayer.Visible = false;
            btnDeletePlayer.Visible = false;
            chkEditPlayer.Checked = false;

            txtEditPlayerName.Text = dgvPlayers.SelectedRows[0].Cells[1].Value.ToString();

            if (dgvPlayers.SelectedRows[0].Cells[2].Value != null)
            {
                for (int i = 0; i < cboEditTeams.Items.Count; i++)
                {
                    cboEditTeams.SelectedIndex = i;

                    Team team = (Team)cboEditTeams.SelectedItem;
                    if (team.TeamName == (string)dgvPlayers.SelectedRows[0].Cells[2].Value)
                    {
                        cboEditTeams.SelectedIndex = i;
                        return;
                    }
                }
            }
            else
                chkEditPlayer.Checked = true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (txtEditPlayerName.Text == "")
            {
                MessageBox.Show("Player Name can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Player player = db.Players.Find(dgvPlayers.SelectedRows[0].Cells[0].Value);

            player.PlayerName = txtEditPlayerName.Text.Trim();
            player.TeamId = chkEditPlayer.Checked ? (int?)null : (int)cboEditTeams.SelectedValue;
            db.SaveChanges();
            txtEditPlayerName.Clear();
            CancelChange();
            int index = dgvPlayers.SelectedRows[0].Index;
            ListPlayers();
            dgvPlayers.Rows[index].Selected = true;



        }

        private void btnCancelNew_Click(object sender, EventArgs e)
        {
            CancelChange();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            chkEditPlayer.Checked = false;
            CancelChange();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtNewPlayerName.Text == "")
            {
                MessageBox.Show("Player Name can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Team selectedTeam = (Team)cboNewTeams.SelectedItem;

            Player newPlayer = new Player { PlayerName = txtNewPlayerName.Text.Trim(), TeamId = chkNewPlayer.Checked ? (int?)null : selectedTeam.Id };
            db.Players.Add(newPlayer);
            db.SaveChanges();
            ListPlayers();
            dgvPlayers.Rows[dgvPlayers.RowCount-1].Selected = true;

            txtNewPlayerName.Clear();
            chkNewPlayer.Checked = false;
            CancelChange();
        }

        private void CancelChange()
        {
            btnAddPlayer.Visible = true;
            btnEditPlayer.Visible = true;
            gboEditPlayer.Visible = false;
            gboNewPlayer.Visible = false;
            btnDeletePlayer.Visible = true;
        }

        private void chkNewPlayer_CheckedChanged(object sender, EventArgs e)
        {
            cboNewTeams.Enabled = !chkNewPlayer.Checked;
        }

        private void chkEditPlayer_CheckedChanged(object sender, EventArgs e)
        {
            cboEditTeams.Enabled = !chkEditPlayer.Checked;
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            if (dgvPlayers.SelectedRows.Count < 1)
            {
                MessageBox.Show("You must choose player to Delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr.ToString() == "No")
                return;

            int index = dgvPlayers.SelectedRows[0].Index;
            Player player = db.Players.Find(dgvPlayers.SelectedRows[0].Cells[0].Value);
            db.Players.Remove(player);
            db.SaveChanges();
            ListPlayers();
            if (dgvPlayers.SelectedRows.Count < 1)
                return;
            else if (index > dgvPlayers.Rows.Count - 1)
                dgvPlayers.Rows[index - 1].Selected = true;
            else
                dgvPlayers.Rows[index].Selected = true;
        }

        private void cboFilterTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cboFilterTeams.SelectedValue;
            Team selected = (Team)cboFilterTeams.SelectedItem;

            if (id > 0)
            {
                dgvPlayers.DataSource = db.Players.Where(x => x.TeamId == id).ToList().Select(x => new
                {
                    Id = x.Id,
                    Name = x.PlayerName,
                    Team = x.TeamId != null ? x.Team.TeamName : null
                }).ToList();

            }
            else if(selected.TeamName == "Free Agents")
            {
                dgvPlayers.DataSource = db.Players.Where(x => x.TeamId == (int?)null).ToList().Select(x => new
                {
                    Id = x.Id,
                    Name = x.PlayerName,
                    Team = x.TeamId != null ? x.Team.TeamName : null
                }).ToList();
            }
            else
            {
                dgvPlayers.DataSource = db.Players.ToList().Select(x => new
                {
                    Id = x.Id,
                    Name = x.PlayerName,
                    Team = x.TeamId != null ? x.Team.TeamName : null
                }).ToList();
            }
        }
    }
}
