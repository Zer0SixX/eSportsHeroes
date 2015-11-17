using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSH.DAL.Entities
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GameId { get; set; }
        public int StatsId { get; set; }

        public virtual Stats Stats { get; set; }
        public virtual Game Game { get; set; }
    }
}
