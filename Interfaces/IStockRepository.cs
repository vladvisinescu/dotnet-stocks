using WebApplication1.Dtos.Stock;
using WebApplication1.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync(QueryObject query);

        Task<Stock?> GetByIdAsync(int id);

        Task<Stock> CreateAsync(Stock stockModel);

        Task<Stock?> UpdateAsync(int id, UpdateStockRequest stockDto);

        Task<Stock?> DeleteAsync(int id);

        Task<bool> StockExists(int id);
    }
}
