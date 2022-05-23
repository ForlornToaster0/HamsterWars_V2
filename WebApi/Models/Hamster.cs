using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    [Table("Table")]
    public class Hamster :IHamster
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
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
