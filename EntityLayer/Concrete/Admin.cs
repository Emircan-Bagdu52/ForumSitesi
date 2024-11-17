﻿using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [StringLength(50)]
        public string AdminUserName { get; set; }
        [StringLength(50)]
        public string AdminPassword { get; set; }
        [StringLength(1)]
        public string AdminRole { get; set; }
        //public bool AdminStatus { get; set; }
        //public int? RoleId { get; set; }
        //public virtual Role Role { get; set; }
    }
}