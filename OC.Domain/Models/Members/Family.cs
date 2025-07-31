using OC.Domain.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace OC.Domain.Models.Members
{
    public class Family : AuditableEntity, IEntityBase
    {
        public Family() { 
            Members = new HashSet<Member>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Member")]
        public long? FamilyAdminId { get; set; }

        // Relationship
        [ForeignKey("FamilyAdminId")]
        public virtual Member Administrator { get; set; }
        public virtual ICollection<Member> Members { get; set; }
    }
}
