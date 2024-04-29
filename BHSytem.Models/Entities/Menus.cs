using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BHSytem.Models.Models;
namespace BHSytem.Models.Entities
{
    public class Menus : Auditable
    {
        [Key]
        public string MenuId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Icon { get; set; }

        [MaxLength(255)]
        public string Link { get; set; }

        public int Level { get; set; }

        [MaxLength(255)]
        public string Parent { get; set; }
        public virtual ICollection<RoleMenus> RoleMenus { get; set; }
    }
}
