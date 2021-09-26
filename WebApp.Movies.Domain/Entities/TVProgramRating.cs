using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Movies.Domain.Entities
{
    public class TVProgramRating
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("TVProgram"), Column(Order = 0)]
        public Guid IDTVProgram { get; set; }

        public virtual TVProgram TVProgram { get; set; }


        [ForeignKey("Rating"), Column(Order = 1)]
        public int IDRating { get; set; }

        public virtual Rating Rating { get; set; }
    }
}
