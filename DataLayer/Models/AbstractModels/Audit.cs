namespace DataLayer.Models.AbstractModels
{
    public abstract class Audit
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }

    }
}
