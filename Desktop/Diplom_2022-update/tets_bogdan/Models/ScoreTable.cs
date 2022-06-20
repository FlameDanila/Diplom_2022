using System;
using System.Collections.Generic;

namespace tets_bogdan.Models
{
    public partial class ScoreTable
    {
        public ScoreTable()
        {
            Teams = new HashSet<Team>();
        }

        public int Id { get; set; }
        public int? ChalangesScore { get; set; }
        public int? LaddersScore { get; set; }
        public int? QuestionsScore { get; set; }
        public int? TowerScore { get; set; }
        public int? PenaltyScore { get; set; }
        public int? TeamId { get; set; }

        public virtual Team? Team { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
