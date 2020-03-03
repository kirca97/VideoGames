using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoGames.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Creator { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int ReleasedYear { get; set; }
        [Required]
        public float Rating { get; set; }
    }
}