using System;
using System.Collections.Generic;

namespace tets_bogdan.Models
{
    public partial class CompetitionCategoryId
    {
        public CompetitionCategoryId()
        {
            Competitions = new HashSet<Competition>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Competition> Competitions { get; set; }
    }
}
