using InvoiceManagement.Application.Abstractions.Repositories;
using InvoiceManagement.Domain.Entities;

namespace InvoiceManagement.Application.Abstractions.Repositories.Homes
{
    public interface IHomeCommandRepository : ICommandRepository<Home>
    {
    }
}
