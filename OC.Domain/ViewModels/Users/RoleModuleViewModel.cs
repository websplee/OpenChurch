using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.ViewModels.Users
{
    public class RoleModuleViewModel
    {
        public long Id { get; set; }
        // Role
        public string RoleId { get; set; }
        public string RoleName { get; set; } = string.Empty;
        // Module
        public long ModuleId { get; set; }
        public string ModuleName { get; set; }= string.Empty;
        // CRUD Rights
        public bool CanView { get; set; }
        public bool CanAddEdit { get; set; }
        public bool CanDelete { get; set; }
        public bool CanApprove { get; set; }
        public bool IsActive { get; set; }
    }
}
