using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Movies.Domain.Entities
{
    public class Rating
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDRating { get; set; }

        [Required(ErrorMessage = "The max length of Caption field is 100 characters!")]
        [MaxLength(100)]
        public int NumberOfStars { get; set; }

        public virtual ICollection<TVProgramRating> TVProgramRating { get; set; }

    }
}


