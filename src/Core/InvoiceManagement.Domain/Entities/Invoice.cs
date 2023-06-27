using InvoiceManagement.Domain.Entities.Common;

namespace InvoiceManagement.Domain.Entities
{
    public abstract class Invoice : BaseEntity
    {
        public int HomeId { get; set; }
        public int UserId { get; set; }
        public string AccountNumber { get; set; }
        public float UsageAmount { get; set; }
        public DateTime PaymentDeadline { get; set; }
        public float UnitPrice { get; set; }
        public float TotalAmount { get; set; }
        public float KDV { get; set; }
        public float Cost { get; set; }
        public float InitialReading { get; set; }//580 + 120
        public float FinalReading { get; set; }//700

        public Home Home { get; set; }
        public User User { get; set; }
    }
}
