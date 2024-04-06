namespace CRM_R_.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        [Required]
        public int EntityLeadId { get; set; }
        [Required]

    }
}
