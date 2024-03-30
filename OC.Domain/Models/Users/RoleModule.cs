using Microsoft.AspNetCore.Identity;
using OC.Domain.Interfaces;

namespace OC.Domain.Models.Users
{
    public class RoleModule : AuditableEntity, IEntityBase
    {
        public RoleModule()
        {
            CanView = false;
            CanAddEdit = false;
            CanDelete = false;
            CanApprove = false;
            CanExport = false;
            CanUpload = false;
            CanDownload = false;
        }
        public long Id { get; set; }
        public string RoleId { get; set; }
        public long ModuleId { get; set; }
        // CRUD Rights
        public bool CanView { get; set; }
        public bool CanAddEdit { get; set; }
        public bool CanDelete { get; set; }
        public bool CanApprove { get; set; }
        public bool CanExport { get; set; }
        public bool CanDownload { get; set; }
        public bool CanUpload { get; set; }


        // Linkages to other entities
        public virtual Module? Module { get; set; }
        public virtual IdentityRole Role { get; set; }
    }
}
