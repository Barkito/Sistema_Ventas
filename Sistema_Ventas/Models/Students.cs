using System.ComponentModel.DataAnnotations;

namespace Sistema_Ventas.Models
{
    public class Students : BaseEntity
    {
        [Required, StringLength(50)]
        public string name { get; set; } = string.Empty;
        [Required, StringLength(100)]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateTime DOB { get; set; } 
        public ICollection<Curso> cursos { get; set; } = new List<Curso>();

    }
}
