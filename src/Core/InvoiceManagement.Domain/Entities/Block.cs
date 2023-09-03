using InvoiceManagement.Domain.Entities.Common;

namespace InvoiceManagement.Domain.Entities
{
    public class Block : BaseEntity
    {
        public string Name { get; set; }
        public string FloorCount { get; set; }

        public List<Home> Homes { get; set; }
    }
}
