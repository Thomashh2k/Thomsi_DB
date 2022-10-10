using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headless.DB.Tables
{
    public class AuthorRole : IdentityRole
    {
        public AccessRights LangAccess { get; set; }
        public AccessRights PageAccess { get; set; }
        public AccessRights CustomFormAccess { get; set; }
        public AccessRights AuthorAccess { get; set; }
        public AccessRights AuthorRolesAccess { get; set; }
    }

    public enum AccessRights
    {
        View = 0,
        Create = 1,
        Update = 2,
        Delete = 3,
        Purge = 4,
    }
}
