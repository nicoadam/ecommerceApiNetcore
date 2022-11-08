using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI
{
    public class EcommerceType
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string EcommerceName { get; set; } = string.Empty;
    }
}
