using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RusDR.Models
{
    public class Congratulation
    {
        public int Id { get; set; }
        public string Person { get; set; } = null;
        public string Video { get; set; } = null;
        public string Meme { get; set; } = null;
        public string Text { get; set; } = null;
        public string Photo { get; set; } = null;
        public string Photo2 { get; set; } = null;
        public List<string> PhotoSet { get; set; } = null;
    }
}
