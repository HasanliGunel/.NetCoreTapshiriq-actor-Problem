using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tapshiriq_actor_.Database
{
    public class ActorMoviecs
    {
        public int ID { get; set; }
        public int ActorID { get; set; }
        public int MovieID { get; set; }
        public Actor Actor { get; set; }
        public Movie Movie { get; set; }
    }
}
