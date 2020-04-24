using System.ComponentModel.DataAnnotations;

namespace VeridiaAPI.Models
{
    public class Npc
    {
        [Key]
        public int Id { get; set; }
        [StringLength(25)]
        public string Name { get; set; }
        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(25)]
        public string Race { get; set; }
        public int Age { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        [StringLength(300)]
        public string Notes { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }
    }
}
