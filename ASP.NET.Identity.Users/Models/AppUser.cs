using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET.Identity.Users.Models
{
    public class AppUser: IdentityUser
    {
        public Guid OrgID { get; set; }
    }
}