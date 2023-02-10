using System.ComponentModel.DataAnnotations;
namespace Sistema_Ventas.Models
{
    public class Temarios : BaseEntity
    {
        public int id { get; set; }
        public virtual Curso cursos { get;set; } = new Curso();
        [Required]
        public string Chapters { get; set; } = string.Empty;
    }
}
