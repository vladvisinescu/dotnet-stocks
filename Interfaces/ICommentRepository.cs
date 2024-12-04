﻿using WebApplication1.Dtos.Comment;
using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();

        Task<Comment?> GetByIdAsync(int id);

        Task<Comment> CreateAsync(Comment commentModel);

        Task<Comment?> UpdateAsync(int id, UpdateCommentRequest commentRequest);

        Task<Comment?> DeleteAsync(int id);
    }
}
