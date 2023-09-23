using InvoiceManagement.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace InvoiceManagement.Application.Abstractions.Repositories
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        DbSet<T> Table { get; }
    }
}
