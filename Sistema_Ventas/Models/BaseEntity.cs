using System.ComponentModel.DataAnnotations;
namespace Sistema_Ventas.Models
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual Users CreateBy { get; set; } = new Users();
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public Users UpdateBy { get; set; } = new Users();
        public DateTime? UpdateAt { get; set; } 
        public Users DeleteBy { get; set; } = new Users();
        public DateTime? DeleteAt { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
