using InvoiceManagement.Application.Abstractions.Repositories.Blocks;
using InvoiceManagement.Domain.Entities;
using InvoiceManagement.Persistence.Contexts;

namespace InvoiceManagement.Persistence.Repositories.Blocks
{
    public class BlockQueryRepository : QueryRepository<Block>, IBlockQueryRepository
    {
        public BlockQueryRepository(InvoiceManagementDbContext context) : base(context) { }
    }
}
