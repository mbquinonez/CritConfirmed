using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CritConfirmed.Entities
{
    public class Character
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public MetaType MetaType { get; set; }
        public int Body { get; set; }
        public int Agility { get; set; }
        public int Reaction { get; set; }
        public int Strength { get; set; }
        public int Charisma { get; set; }
        public int Intuition { get; set; }
        public int Logic { get; set; }
        public int Willpower { get; set; }
        public int Essence { get; set; }
        public int Edge { get; set; }
        public int Magic { get; set; }
        public int Resonance { get; set; }
    }
}
