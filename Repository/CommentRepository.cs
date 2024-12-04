using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Dtos.Comment;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class CommentRepository : ICommentRepository
    {

        private readonly ApplicationDbContext _context;

        public CommentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Comment> CreateAsync(Comment commentModel)
        {
            await _context.Comments.AddAsync(commentModel);

            await _context.SaveChangesAsync();

            return commentModel;
        }

        public async Task<Comment?> DeleteAsync(int id)
        {
            var commentModel = await _context.Comments.FirstOrDefaultAsync(x => x.Id == id);
             
            if (commentModel is null)
            {
                return null;
            }

            _context.Comments.Remove(commentModel);

            await _context.SaveChangesAsync();

            return commentModel;
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comments.ToListAsync();
        }

        public async Task<Comment?> GetByIdAsync(int id)
        {
            return await _context.Comments.FindAsync(id);
        }

        public async Task<Comment?> UpdateAsync(int id, UpdateCommentRequest commentRequest)
        {
            var existingComment = await _context.Comments.FindAsync(id);

            if (existingComment is null)
            {
                return null;
            }

            existingComment.Title = commentRequest.Title;
            existingComment.Content = commentRequest.Content;

            await _context.SaveChangesAsync();

            return existingComment;
        }
    }
}
