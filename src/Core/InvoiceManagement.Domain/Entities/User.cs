using InvoiceManagement.Domain.Entities.Common;

namespace InvoiceManagement.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
