using InvoiceManagement.Application.Abstractions.Repositories.Blocks;
using InvoiceManagement.Domain.Entities;
using InvoiceManagement.Persistence.Contexts;

namespace InvoiceManagement.Persistence.Repositories.Blocks
{
    public class BlockCommandRepository : CommandRepository<Block>, IBlockCommandRepository
    {
        public BlockCommandRepository(InvoiceManagementDbContext context) : base(context){}
    }
}
