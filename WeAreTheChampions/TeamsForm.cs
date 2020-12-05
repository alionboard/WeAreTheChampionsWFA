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
    public partial class TeamsForm : Form
    {
        public event EventHandler TeamsChanged;

        ChampionsContext db;
        public TeamsForm(ChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            dgvTeams.AutoGenerateColumns = false;
            ListTeams();
            btnRemove.Text = "\u2796";
            btnAddToTeam.Text = "\u2795";
        }

        protected virtual void WhenTeamsChanged(EventArgs args)
        {
            if (TeamsChanged != null)
            {
                TeamsChanged(this, args);
            }
        }

        private void ListTeams()
        {
            dgvTeams.DataSource = db.Teams.ToList();
        }

        private void dgvTeams_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTeams.SelectedRows.Count < 1 || lblPlayers.Text == "Free Agents")
                return;
            int teamId = (int)dgvTeams.SelectedRows[0].Cells[0].Value;
            lstPlayers.DataSource = db.Players.Where(x => x.TeamId == teamId).ToList();

            //For EditBoxes
            if (gboTeam.Text == "Edit Team")
            {
                txtFullName.Text = dgvTeams.SelectedRows[0].Cells[1].Value.ToString();
                txtShortName.Text = dgvTeams.SelectedRows[0].Cells[2].Value.ToString();
            }

        }

        private void btnSeeFreeAgents_Click(object sender, EventArgs e)
        {
            ListFreeAgents();
            ChangeVisibility(0);
            lblPlayers.Text = "Free Agents";
        }

        private void ListFreeAgents()
        {
            lstPlayers.DataSource = db.Players.Where(x => x.TeamId == null).ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            ChangeVisibility(0);
            lblPlayers.Text = "Team's Squad";
            int index = dgvTeams.SelectedRows[0].Index;
            ListTeams();
            dgvTeams.Rows[index].Selected = true;
        }

        private void ChangeVisibility(int status)
        {

            if (status == 0)
            {
                btnTeamColors.Visible = !btnTeamColors.Visible;
                btnCancel.Visible = !btnCancel.Visible;
                btnRemove.Visible = !btnRemove.Visible;
                btnNewTeam.Visible = !btnNewTeam.Visible;
                btnEditTeam.Visible = !btnEditTeam.Visible;
                btnAddToTeam.Visible = !btnAddToTeam.Visible;
                btnSeeFreeAgents.Visible = !btnSeeFreeAgents.Visible;
            }

            else if (status == 1)
            {

                gboTeam.Visible = !gboTeam.Visible;
                btnRemove.Visible = !btnRemove.Visible;
                btnNewTeam.Visible = !btnNewTeam.Visible;
                btnEditTeam.Visible = !btnEditTeam.Visible;
                btnTeamColors.Visible = !btnTeamColors.Visible;
                lblPlayerToTeam.Visible = !lblPlayerToTeam.Visible;
                btnSeeFreeAgents.Visible = !btnSeeFreeAgents.Visible;
            }

            else if (status == 2)
            {
                gboTeam.Visible = !gboTeam.Visible;
                btnRemove.Visible = !btnRemove.Visible;
                btnNewTeam.Visible = !btnNewTeam.Visible;
                btnEditTeam.Visible = !btnEditTeam.Visible;
                btnDeleteTeam.Visible = !btnDeleteTeam.Visible;
                btnTeamColors.Visible = !btnTeamColors.Visible;
                lblPlayerToTeam.Visible = !lblPlayerToTeam.Visible;
                btnSeeFreeAgents.Visible = !btnSeeFreeAgents.Visible;
            }

        }

        private void btnAddToTeam_Click(object sender, EventArgs e)
        {
            if (dgvTeams.SelectedRows.Count < 1 || lstPlayers.Items.Count < 1)
                return;
            Player player = (Player)lstPlayers.SelectedItem;
            player.TeamId = (int)dgvTeams.SelectedRows[0].Cells[0].Value;
            db.SaveChanges();
            int indexPlayer = lstPlayers.SelectedIndex;

            ListFreeAgents();
            if (lstPlayers.SelectedIndex < 0)
                return;
            else if (indexPlayer > lstPlayers.Items.Count - 1)
                lstPlayers.SelectedIndex = indexPlayer - 1;
            else
                lstPlayers.SelectedIndex = indexPlayer;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvTeams.SelectedRows.Count < 1 || lstPlayers.Items.Count < 1)
                return;

            Player player = (Player)lstPlayers.SelectedItem;
            player.TeamId = null;
            db.SaveChanges();
            int indexTeam = dgvTeams.SelectedRows[0].Index;
            int indexPlayer = lstPlayers.SelectedIndex;
            ListTeams();
            dgvTeams.Rows[indexTeam].Selected = true;

            if (lstPlayers.SelectedIndex < 0)
                return;
            else if (indexPlayer > lstPlayers.Items.Count - 1)
                lstPlayers.SelectedIndex = indexPlayer - 1;
            else
                lstPlayers.SelectedIndex = indexPlayer;

        }

        private void btnEditTeam_Click(object sender, EventArgs e)
        {
            if (dgvTeams.SelectedRows.Count < 1)
                return;

            ChangeVisibility(1);
            txtFullName.Text = dgvTeams.SelectedRows[0].Cells[1].Value.ToString();
            txtShortName.Text = dgvTeams.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            if (gboTeam.Text == "Edit Team")
            {
                ChangeVisibility(1);
            }
            else
            {
                gboTeam.Text = "Edit Team";
                ChangeVisibility(2);
            }

        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" || txtShortName.Text == "")
            {
                MessageBox.Show("Full and short names can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string teamNameTxt = txtFullName.Text.Trim();
            string shortNameTxt = txtShortName.Text.Trim();
            if (db.Teams.Any(x => x.ShortName == shortNameTxt || x.TeamName == teamNameTxt))
            {
                MessageBox.Show("There is a team with same name or short name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gboTeam.Text == "Edit Team")
            {
                Team team = (Team)dgvTeams.SelectedRows[0].DataBoundItem;
                team.TeamName = teamNameTxt;
                team.ShortName = shortNameTxt;

                db.SaveChanges();
                ChangeVisibility(1);
                int index = dgvTeams.SelectedRows[0].Index;
                ListTeams();
                dgvTeams.Rows[index].Selected = true;
            }
            else
            {
                Team team = new Team { TeamName = teamNameTxt, ShortName = shortNameTxt};
                
                db.Teams.Add(team);
                db.SaveChanges();
                ListTeams();
                ChangeVisibility(2);
                int index = dgvTeams.RowCount;
                dgvTeams.Rows[index - 1].Selected = true;
                gboTeam.Text = "Edit Team";
            }
            WhenTeamsChanged(EventArgs.Empty);

        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            if (dgvTeams.SelectedRows.Count < 1)
                return;

            DialogResult dr = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr.ToString() == "No")
                return;

            Team team = (Team)dgvTeams.SelectedRows[0].DataBoundItem;

            if (db.Players.Any(x => x.TeamId == team.Id) || db.Matches.Any(x => x.Team1Id == team.Id || x.Team2Id == team.Id))
            {
                MessageBox.Show("This team can't be deleted! It is relative with matches or players.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                db.Teams.Remove(team);
                db.SaveChanges();
            }
            ChangeVisibility(1);
            ListTeams();
            WhenTeamsChanged(EventArgs.Empty);


        }

        private void btnNewTeam_Click(object sender, EventArgs e)
        {
            gboTeam.Text = "New Team";
            txtFullName.Clear();
            txtShortName.Clear();
            ChangeVisibility(2);
        }

        private void btnTeamColors_Click(object sender, EventArgs e)
        {
            if (dgvTeams.SelectedRows.Count < 1)
                return;

            Team team = (Team)dgvTeams.SelectedRows[0].DataBoundItem;

            TeamColorsForm teamColorsForm = new TeamColorsForm(/*db,*/ team.Id);
            teamColorsForm.ShowDialog();
        }

    }
}
