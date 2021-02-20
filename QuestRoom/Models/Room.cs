using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestRoom.Models
{
    public enum Difficulty
    {
        Begginer = 1,
        Easy,
        Normal,
        Hard,
        Expert
    }
    public class Room
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 20)]
        public string Description { get; set; }
        public int TimeOfPassing { get; set; }
        [Required]
        public int MinAmountOfPlayers { get; set; }
        public int MaxAmountOfPlayers { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Range(1, 5)]
        public float Rating { get; set; }
        public int LevelOfFear { get; set; }
        [Range(1, 5)]
        public Difficulty LevelOfDifficulty { get; set; }
    }
}
