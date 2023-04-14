using System.ComponentModel.DataAnnotations;

namespace Item_App.Models
{
    public class Items
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Name { get; set; }
        [Required]
        [Range(0, 500)]
        public int Price { get; set; }   
    }
}
