using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI
{
    public class Ecommerce
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = string.Empty;

        [StringLength(200)]
        public string Comments { get; set; } =string .Empty;

        public int EcommerceTypeId { get; set; }

        public EcommerceType? EcommerceType { get; set;}


    }
}
