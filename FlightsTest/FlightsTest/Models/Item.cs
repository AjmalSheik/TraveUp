using System.ComponentModel.DataAnnotations;

namespace FlightsTest.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Item Name")]
        public string Name { get; set; }
    }
}
