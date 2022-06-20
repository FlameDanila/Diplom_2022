using System;
using System.Collections.Generic;

namespace tets_bogdan.Models
{
    public partial class Block
    {
        public int Id { get; set; }
        public string? TypeBlock { get; set; }
        public int? TypeId { get; set; }
        public int? CountCells { get; set; }
        public int? DockingEnable { get; set; }
        public int? Points { get; set; }
        public string? Photo { get; set; }

        public virtual TypesId? Type { get; set; }
    }
}
