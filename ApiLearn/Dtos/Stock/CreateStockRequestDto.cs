using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiLearn.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        [Required]
        [MaxLength(15)]
        public string Symbol { get; set; } = string.Empty;
        [Required]
        [MaxLength(30)]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        [Range(1, 1000000000)]
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.0001, 1000000)]
        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength (30)]
        public string Industry { get; set; } = string.Empty;
        [Required]
        [Range(1,1000000000000)]
        public long MarketCap { get; set; }
    }
}
