using System.ComponentModel.DataAnnotations;

namespace CRM_R_.Entities
{
    public class Lead
    {
        public string Id { get; set; }
        [Required]
        public int EntityContact {  get; set; }
        public int? EntityUserId { get; set; }
        [Required]
        public LeadStatus Status { get; set; }
        [Required]
        public EntityConatct? Contact {  get; set; }
        public EntityUser? User { get; set; }
        public List<>
    }
}
