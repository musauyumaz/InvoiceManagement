using InvoiceManagement.Application.Abstractions.Repositories.Homes;
using InvoiceManagement.Domain.Entities;
using InvoiceManagement.Persistence.Contexts;

namespace InvoiceManagement.Persistence.Repositories.Homes
{
    public class HomeCommandRepository : CommandRepository<Home>, IHomeCommandRepository
    {
        public HomeCommandRepository(InvoiceManagementDbContext context) : base(context){}
    }
}
