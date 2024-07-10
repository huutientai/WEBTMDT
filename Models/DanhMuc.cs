using System.ComponentModel.DataAnnotations;

namespace webTMDT.Models
{
    public class DanhMuc
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Namedanhmuc { get; set; }
        public DateTime Description { get; set; } = DateTime.Now;
    }
}
