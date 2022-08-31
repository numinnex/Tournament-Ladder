using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Ladder
{
    internal class TeamModel
    {
        public int Id { get; set; }
        public bool? Winner { get; set; } = null;
        public int? Round { get; set; } = null;
    }
}
