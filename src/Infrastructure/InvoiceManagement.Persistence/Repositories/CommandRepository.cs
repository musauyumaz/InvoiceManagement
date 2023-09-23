using InvoiceManagement.Application.Abstractions.Repositories;
using InvoiceManagement.Domain.Entities.Common;
using InvoiceManagement.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace InvoiceManagement.Persistence.Repositories
{
    public class CommandRepository<T> : ICommandRepository<T> where T : BaseEntity, new()
    {
        private readonly InvoiceManagementDbContext _context;

        public CommandRepository(InvoiceManagementDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<T> AddAsync(T model)
            => (await Table.AddAsync(model)).Entity;

        public async Task<T> RemoveAsync(int id)
        {
            T entity = await Table.FirstOrDefaultAsync(data => data.Id == id);
            entity.IsActive = false;
            return entity;
        }

        public async Task<int> SaveAsync()
            => await _context.SaveChangesAsync();

        public async Task<T> UpdateAsync(T model)
        {
            T entity = await Table.FirstOrDefaultAsync(data => data.Id == model.Id);
            entity = model;
            Table.Update(entity);
            return entity;
        }
    }
}
