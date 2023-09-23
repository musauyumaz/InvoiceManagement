using InvoiceManagement.Application.Abstractions.Repositories.Homes;
using InvoiceManagement.Domain.Entities;
using InvoiceManagement.Persistence.Contexts;

namespace InvoiceManagement.Persistence.Repositories.Homes
{
    public class HomeQueryRepository : QueryRepository<Home>, IHomeQueryRepository
    {
        public HomeQueryRepository(InvoiceManagementDbContext context) : base(context) { }
    }
}
