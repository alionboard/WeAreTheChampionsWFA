using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    public class MyInitStrategy : DropCreateDatabaseAlways<ChampionsContext>
    {
        protected override void Seed(ChampionsContext context)
        {
            Team team1 = new Team { TeamName = "Galatasaray", ShortName = "GS" };
            Team team2 = new Team { TeamName = "Fenerbahçe", ShortName = "FB" };
            Team team3 = new Team { TeamName = "Beşiktaş", ShortName = "BJK" };
            Team team4 = new Team { TeamName = "Trabzonspor", ShortName = "TS" };

            Match match1 = new Match { Team1Id = 1, Team2Id = 2, MatchTime = new DateTime(2020,12,05,19,45,0), Result = Result.Team1Won, Score1 = 3, Score2 = 1 };
            Match match2 = new Match { Team1Id = 3, Team2Id = 4, MatchTime = new DateTime(2020, 11, 04, 18, 00, 0), Result = Result.Draw, Score1 = 0, Score2 = 0 };
            Match match3 = new Match { Team1Id = 2, Team2Id = 1, MatchTime = new DateTime(2019, 01, 03, 20, 30, 0), Result = Result.Draw, Score1 = 2, Score2 = 2 };
            Match match4 = new Match { Team1Id = 4, Team2Id = 1, MatchTime = new DateTime(2020, 12, 25, 20, 45, 0),};
            Match match5 = new Match { Team1Id = 1, Team2Id = 3, MatchTime = DateTime.Now};

            Player player1 = new Player { PlayerName = "Sneijder",TeamId=1 };
            Player player2 = new Player { PlayerName = "Ozan Tufan", TeamId = 2 };
            Player player3 = new Player { PlayerName = "Aboubakar", TeamId = 3 };
            Player player4 = new Player { PlayerName = "Muslera",TeamId = 1 };
            Player player5 = new Player { PlayerName = "Volkan Babacan",TeamId=4};
            Player player6 = new Player { PlayerName = "Ronaldo"};
            Player player7 = new Player { PlayerName = "Messi"};
            Player player8 = new Player { PlayerName = "Neymar"};
            Player player9 = new Player { PlayerName = "Falcao", TeamId = 1 };
            Player player10 = new Player { PlayerName = "Felipe Melo", TeamId = 1 };
            Player player11 = new Player { PlayerName = "Younes Belhanda", TeamId = 1 };
            Player player12 = new Player { PlayerName = "Alex", TeamId = 2 };
            Player player13 = new Player { PlayerName = "Sergen Yalçın", TeamId = 3 };
            Player player14 = new Player { PlayerName = "Cavanda", TeamId = 4 };
            Player player15 = new Player { PlayerName = "Yusuf", TeamId = 4 };

            Color color1 = new Color { ColorName = "Red", Red = 255, Blue = 0, Green = 0 };
            Color color2 = new Color { ColorName = "Green", Red = 0, Blue = 0, Green = 255 };
            Color color3 = new Color { ColorName = "Blue", Red = 0, Blue = 255, Green = 0 };

            context.Teams.AddRange(new Team[] { team1, team2, team3, team4 });
            context.SaveChanges();
            context.Matches.AddRange(new Match[] { match1, match2,match3,match4,match5 });
            context.SaveChanges();
            context.Players.AddRange(new Player[] { player1, player2, player3, player4, player5, player6, player7, player8, player9, player10, player11, player12, player13, player14, player15 });
            context.SaveChanges();
            context.Colors.AddRange(new Color[] { color1, color2, color3 });
            context.SaveChanges();
        }
    }

}
