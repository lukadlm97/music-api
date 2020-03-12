using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.Data.Model
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public string Author { get; set; }
        public Performer Performer { get; set; }
    }
}
