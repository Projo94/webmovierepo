using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Movies.Domain.Entities
{
    public class Actor
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDActor { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }


        public virtual ICollection<ActorTVProgram> ActorTVProgram { get; set; }

    }
}
