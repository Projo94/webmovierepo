using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApp.Movies.Domain.Common;

namespace WebApp.Movies.Domain.Entities
{
    public class TVProgram
    {

        [Key]
        public Guid IDTVProgram { get; set; }


        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Column(TypeName = "Date")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [MaxLength(400)]
        public string Description { get; set; }


        [Required]
        public string PictureDisplay { get; set; }


        [ForeignKey("TypeOfProgramID")]
        public TypeOfProgram TypeOfProgram { get; set; }

        public int TypeOfProgramID { get; set; }


        public virtual ICollection<TVProgramRating> TVProgramRating { get; set; }


        public virtual ICollection<ActorTVProgram> ActorTVProgram { get; set; }


    }
}
