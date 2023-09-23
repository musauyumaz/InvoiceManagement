using InvoiceManagement.Domain.Entities.Common;

namespace InvoiceManagement.Application.Abstractions.Repositories
{
    public interface IQueryRepository<T> : IRepository<T> where T : BaseEntity, new()
    {
        IQueryable<T> GetAll();
        Task<T> GetByIdAsync(int id);
    }
}
