using InvoiceManagement.Domain.Entities.Common;

namespace InvoiceManagement.Application.Abstractions.Repositories
{
    public interface ICommandRepository<T> : IRepository<T> where T : BaseEntity, new()
    {
        Task<T> AddAsync(T model);
        Task<T> RemoveAsync(int id);
        Task<T> UpdateAsync(T model);
        Task<int> SaveAsync();
    }
}
