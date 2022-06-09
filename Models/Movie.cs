using System.ComponentModel.DataAnnotations;

namespace InventoryBeginners.Models
{
    public class Movie
    {

        public int ID { get; set; }

        [Required]
        [StringLength (250)]
        public string Name { get; set; } = String.Empty;

        [Required]
        [StringLength(500)]
        public string Description { get; set; } = String.Empty;

        [Required]
        [StringLength(500)]
        public string ImagePath { get; set; } = String.Empty;
    }
}
