using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Movies.Domain.Entities
{
    public class TypeOfProgram
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDTypeOfProgram { get; set; }

        [Required(ErrorMessage = "The max length of Caption field is 100 characters!")]
        [MaxLength(10)]
        public string Caption { get; set; }

    }
}
