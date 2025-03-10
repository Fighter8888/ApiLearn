using ApiLearn.Dtos.Comment;
using ApiLearn.Models;

namespace ApiLearn.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();
        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment commentModel);
        Task<Comment?> UpdateAsync(int id, Comment commentModel); //Comment commentModel
        Task<Comment?> DeleteAsync(int id);
    }
}
