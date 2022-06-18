using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBikeShop.Models
{
    public class Model
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Model")]
        public string? Name { get; set; }
        public Make Make { get; set; }

        [ForeignKey("MakeId")]
        public int MakeId { get; set; }
    }
}
