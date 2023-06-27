namespace InvoiceManagement.Domain.Entities
{
    public class WaterBill : Invoice
    {
        public float WasteWaterTax { get; set; }
        public float EnvironmentalCleaningTax { get; set; }
    }
}
