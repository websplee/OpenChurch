using System.ComponentModel.DataAnnotations.Schema;

namespace OC.Domain.ViewModels.Members
{
    public class FamilyNewViewModel 
    {        
        public string Name { get; set; }
        public long? FamilyAdminId { get; set; }
        
    }
}
