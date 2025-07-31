using System.ComponentModel.DataAnnotations.Schema;

namespace OC.Domain.ViewModels.Members
{
    public class FamilyViewModel 
    {
        public long Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Member")]
        public long? FamilyAdminId { get; set; }
        public bool IsActive { get; set; }

        // Relationship
        [ForeignKey("FamilyAdminId")]
        public virtual MemberViewModel? Administrator { get; set; }
        public virtual ICollection<MemberViewModel>? Members { get; set; }
    }
}
