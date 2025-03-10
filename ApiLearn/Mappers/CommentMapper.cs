using ApiLearn.Dtos.Comment;
using ApiLearn.Dtos.Stock;
using ApiLearn.Models;

namespace ApiLearn.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment CommentModel)
        {
            return new CommentDto
            {
                Id = CommentModel.Id,
                Title = CommentModel.Title,
                Content = CommentModel.Content,
                CreatedOn = CommentModel.CreatedOn,
                StockId = CommentModel.StockId
            };
        }

        public static Comment ToCommentFromCreateDto(this CreateCommentRequestDto CommentDto, int stockId)
        {
            return new Comment
            {
                Title = CommentDto.Title,
                Content = CommentDto.Content,
                StockId = stockId
            };
        }

        public static Comment ToCommentFromUpdate(this UpdateCommentRequestDto CommentDto)
        {
            return new Comment
            {
                Title = CommentDto.Title,
                Content = CommentDto.Content
            };
        }
    }
}