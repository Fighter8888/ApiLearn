using System.ComponentModel.DataAnnotations;

namespace ApiLearn.Dtos.Comment
{
    public class CreateCommentRequestDto
    {
        [Required]
        [MinLength(4, ErrorMessage = "Do Not Be lazy")]
        [MaxLength(50, ErrorMessage = "It is a title Not a Poem")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MinLength(10, ErrorMessage = "Do Not Be lazy")]
        [MaxLength(280, ErrorMessage = "It is a simple Content Not a Book")]
        public string Content { get; set; } = string.Empty;
    }
}
