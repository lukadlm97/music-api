using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.Data.Model
{
    public class Performer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsBand { get; set; }
        public List<Member> BandMembers { get; set; }

    }
}
