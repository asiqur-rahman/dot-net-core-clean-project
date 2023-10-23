﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project.Core.Entities.Common
{
    [Table("Roles")]
    public class Role : IdentityRole<int>
    {
        [Display(Name = "Role Name"), Required]
        [StringLength(50, ErrorMessage = "{0} can have a max of {1} characters")]
        public override string Name { get; set; }

        [Display(Name = "Status")]
        public bool ActiveStatus { get; set; }

        [Display(Name = "Permitted Modules")]
        public string PermittedModule { get; set; }

        //public virtual IEnumerable<User> Users { get; set; }
        //public virtual IEnumerable<MenuConfig> MenuConfigs { get; set; }
        public virtual ICollection<IdentityRoleClaim<int>> Claims { get; set; }
    }
}
