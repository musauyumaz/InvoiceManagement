namespace InvoiceManagement.Domain.Entities.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime UpdatedDate { get; set; }
    }
}
