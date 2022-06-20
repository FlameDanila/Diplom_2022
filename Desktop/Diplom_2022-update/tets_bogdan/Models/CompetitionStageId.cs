using System;
using System.Collections.Generic;

namespace tets_bogdan.Models
{
    public partial class CompetitionStageId
    {
        public CompetitionStageId()
        {
            Competitions = new HashSet<Competition>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Competition> Competitions { get; set; }
    }
}
