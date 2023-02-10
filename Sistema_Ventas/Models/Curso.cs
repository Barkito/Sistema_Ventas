using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Sistema_Ventas.Models
{
    public enum Nivel
    {
        Basico ,
        Intermedio ,
        Avanzado ,
        Experto
    };
    public class Curso : BaseEntity
    {
        [Required, StringLength(50)]
        public string name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string descriptionShort { get; set; } = string.Empty;
        [Required, StringLength(560)]
        public string descriptionLong { get; set; } = string.Empty;
        [Required, StringLength(100)]
        public string publicObject { get; set; } = string.Empty;
        [Required,StringLength(100)]
        public string Object { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string required { get; set; } = string.Empty;
        public Nivel NivelId { get; set; } = Nivel.Basico;

        [Required]
        public ICollection<Category> categories { get; set; }   = new List<Category>();

        [Required]
        public Temarios temary { get; set; } = new Temarios();
        [Required]
        public ICollection<Students> students { get; set; } = new List<Students>();
    }
}
