using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("Team")]
    public class Team
    {
        public Team()
        {
            this.Colors = new HashSet<Color>();
            this.Players = new HashSet<Player>();
            this.Matches = new HashSet<Match>();
        }
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string TeamName { get; set; }
        [Required, MaxLength(6)]
        public string ShortName { get; set; }
        public virtual ICollection<Color> Colors { get; set; }
        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Match> Matches { get; set; }



    }
}
