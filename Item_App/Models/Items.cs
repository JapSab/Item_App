using System.ComponentModel.DataAnnotations;

namespace Item_App.Models
{
    public class Items
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }   
    }
}
