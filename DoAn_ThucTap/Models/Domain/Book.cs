using DoAn_ThucTap.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn_ThucTap.Models.Domain
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Ten Sach")]
        public string? Name { get; set; }
        
        public string? Nxb { get; set; }
        
        public string? Specialized { get; set; }
        
        public string? Image { get; set; }
        
        public int ? DayCreate { get; set; }


    }
}