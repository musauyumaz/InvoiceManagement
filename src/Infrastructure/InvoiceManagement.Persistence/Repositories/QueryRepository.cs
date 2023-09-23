using InvoiceManagement.Application.Abstractions.Repositories;
using InvoiceManagement.Domain.Entities.Common;
using InvoiceManagement.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace InvoiceManagement.Persistence.Repositories
{
    public class QueryRepository<T> : IQueryRepository<T> where T : BaseEntity, new()
    {
        private readonly InvoiceManagementDbContext _context;

        public QueryRepository(InvoiceManagementDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table.AsQueryable();

        public async Task<T> GetByIdAsync(int id)
            => await Table.AsQueryable().FirstOrDefaultAsync(data => data.Id == id);
    }
}