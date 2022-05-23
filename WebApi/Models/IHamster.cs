using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public interface IHamster
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } 
        public int Age { get; set; }
        [StringLength(50)]
        public string? FavFood { get; set; }
        [StringLength(50)]
        public string? Loves { get; set; }
        [StringLength(50)]
        public string? ImgName { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Games { get; set; }
    }
}
