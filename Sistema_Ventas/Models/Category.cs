using System.ComponentModel.DataAnnotations;
namespace Sistema_Ventas.Models
{
    public class Category : BaseEntity
    {
        [Required, StringLength(50)]
        public string name { get; set; } = string.Empty;
        public ICollection<Curso> cursos { get; set; } = new List<Curso>(); 
    }
}
