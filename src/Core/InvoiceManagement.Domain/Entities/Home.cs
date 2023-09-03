using InvoiceManagement.Domain.Entities.Common;

namespace InvoiceManagement.Domain.Entities
{
    public class Home : BaseEntity
    {
        public int LandlordId { get; set; }
        public int? BlockId { get; set; }
        public int? ResidentId { get; set; }
        public string DoorNumber { get; set; }
        public string FloorNumber { get; set; }
        public int? Size { get; set; }
        public string RoomCount { get; set; }
        public bool UsageStatus { get; set; }
        public string FullAddress { get; set; }

        public User LandLord { get; set; }
        public User Resident { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
        public Block Block { get; set; }
    }
}
