using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGames.Models
{
    public class Item
    {
        public VideoGame VideoGame { get; set; }
        public int Quantity { get; set; }
    }
}