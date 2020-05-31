using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class OrderInstruction
    {
        public int WmspOrder { get; set; }
        public string Instruction { get; set; }
        public string Storer { get; set; }
    }
}
