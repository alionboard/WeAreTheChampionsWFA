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
    public partial class Form1 : Form
    {
        ChampionsContext db = new ChampionsContext();
        public Form1()
        {
            InitializeComponent();
            dgvMatches.AutoGenerateColumns = false;
            btnAddGame.Text = "\u2795";
            ListGames();
        }

        private void ListGames()
        {

            dgvMatches.DataSource = db.Matches.OrderByDescending(x => x.MatchTime).ToList().Select(x => new
            {
                Id=x.Id,
                HomeTeam = x.Team1.ShortName,
                AwayTeam = x.Team2.ShortName,
                Date=x.MatchTime.Value.ToShortDateString(),
                Time=x.MatchTime.Value.ToShortTimeString(),
                Result=x.Result==null?"?-?":$"{x.Score1}-{x.Score2}"
            }).ToList();

        }

        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamsForm teamsForm = new TeamsForm(db);
            teamsForm.TeamsChanged += TeamsForm_TeamsChanged;
            teamsForm.ShowDialog();
        }

        private void TeamsForm_TeamsChanged(object sender, EventArgs e)
        {
            ListGames();
        }

        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayersForm playersForm = new PlayersForm(db);
            playersForm.ShowDialog();
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            GamesForm gamesForm = new GamesForm(db);
            gamesForm.GamesChanged += GamesForm_GamesChanged;
            gamesForm.ShowDialog();
        }

        private void GamesForm_GamesChanged(object sender, EventArgs e)
        {
            ListGames();
        }

        private void chkFilterCompletedGames_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFilterCompletedGames.Checked)
            {
                dgvMatches.DataSource = db.Matches.OrderByDescending(x=>x.MatchTime).ToList().Where(x=>x.Result==null).Select(x => new
                {
                    HomeTeam = x.Team1.ShortName,
                    AwayTeam = x.Team2.ShortName,
                    Date = x.MatchTime.Value.ToShortDateString(),
                    Time = x.MatchTime.Value.ToShortTimeString(),
                    Result = x.Result == null ? "?-?" : $"{x.Score1}-{x.Score2}"
                }).ToList();
            }
            else
            {
                ListGames();
            }
        }

        private void dgvMatches_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count < 1)
                return;
            var game = (dynamic)dgvMatches.CurrentRow.DataBoundItem;
            GamesForm gamesForm = new GamesForm(db, game.Id);
            gamesForm.GamesChanged += GamesForm_GamesChanged;
            gamesForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMatches.Rows.Count < 1)
                return;
            DialogResult dr = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr.ToString() == "No")
                return;
            var game = (dynamic)dgvMatches.CurrentRow.DataBoundItem;
            int index = dgvMatches.CurrentRow.Index;
            db.Matches.Remove(db.Matches.Find(game.Id));
            db.SaveChanges();
            ListGames();
            if (dgvMatches.SelectedRows.Count < 1)
                return;
            else if (index > dgvMatches.Rows.Count - 1)
                dgvMatches.Rows[index - 1].Selected = true;
            else
                dgvMatches.Rows[index].Selected = true;
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorsForm colorsForm = new ColorsForm(db);
            colorsForm.ShowDialog();
        }
    }


}
