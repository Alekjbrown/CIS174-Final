using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeridiaApp.Models
{
    public class NpcViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender {get;set;}
        public string Race { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }

    }
}
