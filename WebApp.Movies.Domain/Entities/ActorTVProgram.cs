using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Movies.Domain.Entities
{
    public class ActorTVProgram
    {

        [ForeignKey("TVProgram"), Column(Order = 0)]
        public Guid IDTVProgram { get; set; }

        public virtual TVProgram TVProgram { get; set; }


        [ForeignKey("Actor"), Column(Order = 1)]
        public int IDActor { get; set; }

        public virtual Actor Actor { get; set; }

    }
}
