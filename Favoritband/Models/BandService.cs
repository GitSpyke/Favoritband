using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Favoritband.Models
{
    public class BandService
    {
        static List<Band> bands = new List<Band>
        {
            new Band{ Id = 1, Name = "Linkin Park", Description = "Rock", Image = "/Linkin-park.jpg" },
            new Band{ Id = 2, Name = "Hot Chip", Description = "Pepp", Image = "/Hot-Chip.webp"},
            new Band{ Id = 3, Name = "Beastie boys", Description = "Hip Hop", Image = "/Beastie_Boys.jpg" },
            new Band{ Id = 4, Name = "Guns and Roses", Description = "Paradise city", Image = "/Guns-N-Roses.jpg" },

        };

        public Band GetBandById(int id)
        {
            return bands
                .Where(o => o.Id == id)
                .FirstOrDefault();
                
        }

        public Band[] GetAllBands()
        {
            return bands
                .OrderBy(o => o.Name)
                .ToArray();

        }
    }
}
