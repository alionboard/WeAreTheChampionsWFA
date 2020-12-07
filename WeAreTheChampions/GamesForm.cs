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
    public partial class GamesForm : Form
    {
        ChampionsContext db;
        private int gameId;

        public event EventHandler GamesChanged;
        public GamesForm(ChampionsContext db, int gameId)
        {
            this.db = db;
            this.gameId = gameId;
            InitializeComponent();
            FillSourcesForEdit();
        }
        public GamesForm(ChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            FillSources();
        }

        private void FillSourcesForEdit()
        {
            FillSources();
            btnSave.Text = "Save";
            Match match = db.Matches.Find(gameId);
            for (int i = 0; i < cboTeam1.Items.Count; i++)
            {
                cboTeam1.SelectedIndex = i;

                Team team = (Team)cboTeam1.SelectedItem;
                if (team.Id == match.Team1Id)
                {
                    cboTeam1.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cboTeam2.Items.Count; i++)
            {
                cboTeam2.SelectedIndex = i;

                Team team = (Team)cboTeam2.SelectedItem;
                if (team.Id == match.Team2Id)
                {
                    cboTeam2.SelectedIndex = i;
                    break;
                }
            }

            dtpDate.Value = match.MatchTime.Value.Date;
            dtpTime.Value = match.MatchTime.Value;

            if (match.Result != null)
            {
                chkGameStatus.Checked = true;
                txtTeam1Score.Text = match.Score1.ToString();
                txtTeam2Score.Text = match.Score2.ToString();
            }
        }

        private void FillSources()
        {
            cboTeam1.DataSource = db.Teams.ToList();
            cboTeam2.DataSource = db.Teams.ToList();
        }

        protected virtual void WhenGamesChanged(EventArgs args)
        {
            if (GamesChanged != null)
            {
                GamesChanged(this, args);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chkGameStatus.Checked && (txtTeam1Score.Text == "" || txtTeam2Score.Text == ""))
            {
                MessageBox.Show("If the game was finished, you must enter scores!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboTeam1.SelectedIndex < 0 || cboTeam2.SelectedIndex < 0)
            {
                MessageBox.Show("You must choose teams!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int homeScore = 0;
            int awayScore = 0;
            try
            {
                if (chkGameStatus.Checked)
                {
                    homeScore = Convert.ToInt32(txtTeam1Score.Text);
                    awayScore = Convert.ToInt32(txtTeam2Score.Text);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("You must enter scores as Numeric!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime dateTime = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;
            Result result;

            if (chkGameStatus.Checked)
            {
                if (homeScore > awayScore)
                    result = Result.Team1Won;
                else if (homeScore < awayScore)
                    result = Result.Team2Won;
                else
                    result = Result.Draw;
                if (btnSave.Text == "Save")
                {

                    Match match = db.Matches.Find(gameId);
                    match.Team1Id = (int)cboTeam1.SelectedValue;
                    match.Team2Id = (int)cboTeam2.SelectedValue;
                    match.MatchTime = dateTime;
                    match.Score1 = homeScore;
                    match.Score2 = awayScore;
                    match.Result = result;
                }
                else
                {
                    Match match = new Match { Team1Id = (int)cboTeam1.SelectedValue, Team2Id = (int)cboTeam2.SelectedValue, Score1 = homeScore, Score2 = awayScore, MatchTime = dateTime, Result = result };
                    db.Matches.Add(match);
                }
                db.SaveChanges();
                GamesChanged(this, EventArgs.Empty);
                Close();
            }
            else
            {
                if (btnSave.Text == "Save")
                {
                    Match match = db.Matches.Find(gameId);
                    match.Team1Id = (int)cboTeam1.SelectedValue;
                    match.Team2Id = (int)cboTeam2.SelectedValue;
                    match.MatchTime = dateTime;
                    match.Result = null;
                }
                else
                {
                    Match match = new Match { Team1Id = (int)cboTeam1.SelectedValue, Team2Id = (int)cboTeam2.SelectedValue, MatchTime = dateTime };
                    db.Matches.Add(match);
                }

                db.SaveChanges();
                GamesChanged(this, EventArgs.Empty);
                Close();
            }

        }

        private void chkGameStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGameStatus.Checked)
            {
                txtTeam1Score.Visible = true;
                txtTeam2Score.Visible = true;
                lblScores.Visible = true;
                lblSeperator.Visible = true;
            }
            else
            {
                txtTeam1Score.Visible = false;
                txtTeam2Score.Visible = false;
                lblScores.Visible = false;
                lblSeperator.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboTeam1_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((Team)cboTeam1.SelectedItem == (Team)cboTeam2.SelectedItem)
            {
                for (int i = 0; i < cboTeam2.Items.Count; i++)
                {
                    if (cboTeam1.SelectedIndex != i)
                    {
                        cboTeam2.SelectedIndex = i;
                        break;
                    }
                }
            }


        }
        private void cboTeam2_SelectedValueChanged(object sender, EventArgs e)
        {

            if ((Team)cboTeam1.SelectedItem == (Team)cboTeam2.SelectedItem)
            {
                for (int i = 0; i < cboTeam1.Items.Count; i++)
                {
                    if (cboTeam2.SelectedIndex != i)
                    {
                        cboTeam1.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

    }
}
