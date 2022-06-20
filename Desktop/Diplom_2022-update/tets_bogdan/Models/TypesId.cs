using System;
using System.Collections.Generic;

namespace tets_bogdan.Models
{
    public partial class TypesId
    {
        public TypesId()
        {
            Blocks = new HashSet<Block>();
        }

        public int Id { get; set; }
        public string? NameType { get; set; }

        public virtual ICollection<Block> Blocks { get; set; }
    }
}
