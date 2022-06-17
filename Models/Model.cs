using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBikeShop.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Make Make { get; set; }

        [ForeignKey("MakeId")]
        public int MakeId { get; set; }
    }
}
