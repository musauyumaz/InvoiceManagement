namespace InvoiceManagement.Domain.Entities
{
    public class ElectricityBill : Invoice
    {
        public float Trt { get; set; }
        public float EnergyFund { get; set; }
        public float ElectricityConsumptionTax { get; set; }
    }
}
