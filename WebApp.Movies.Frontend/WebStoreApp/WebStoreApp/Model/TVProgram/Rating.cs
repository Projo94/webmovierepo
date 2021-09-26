using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Model.TVProgram
{
    public class Rating
    {


        public Rating(Guid IDTVProgram, int IDRating)
        {

            this.IDRating = IDRating;
            this.IDTVProgram = IDTVProgram;

        }
        public Guid IDTVProgram { get; set; }
        public int IDRating { get; set; }
    }
}
