using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Dtos.Comment
{
    public class CreateCommentRequest
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be 5 characters long.")]
        [MaxLength(280, ErrorMessage = "Title must be less than 280 characters long.")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MinLength(5, ErrorMessage = "Content must be 5 characters long.")]
        [MaxLength(280, ErrorMessage = "Content must be less than 280 characters long.")]
        public string Content { get; set; } = string.Empty;
    }
}
