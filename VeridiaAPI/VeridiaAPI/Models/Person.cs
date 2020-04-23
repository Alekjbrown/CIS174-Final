using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VeridiaAPI.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [StringLength(25)]
        public string Name { get; set; }
        [StringLength(10)]
        public string gender { get; set; }

        [StringLength(25)]
        public string Race { get; set; }
        public int age { get; set; }
        [StringLength(300)]
        public string description { get; set; }
        [StringLength(300)]
        public string notes { get; set; }
        public int str { get; set; }
        public int dex { get; set; }
        public int con { get; set; }
        public int intel { get; set; }
        public int wis { get; set; }
        public int cha { get; set; }
    }
}
