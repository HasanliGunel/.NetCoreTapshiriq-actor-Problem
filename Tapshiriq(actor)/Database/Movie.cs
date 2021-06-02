using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tapshiriq_actor_.Database
{
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<ActorMoviecs> ActorMoviecs { get; set; }
    }
}
