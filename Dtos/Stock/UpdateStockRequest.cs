using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Dtos.Stock
{
    public class UpdateStockRequest
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol must be less than 10 characters long.")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [MaxLength(30, ErrorMessage = "Company Name must be less than 10 characters long.")]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        [Range(1, 100000000000)]
        public decimal Purchase { get; set; }

        [Required]
        [Range(0.001, 100)]
        public decimal LastDiv { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Industry cannot be over 20 characters long.")]
        public string Industry { get; set; } = string.Empty;

        [Required]
        [Range(1, 5000000000)]
        public long MarketCap { get; set; }
    }
}
