using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BkaShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //ID sẽ tự tăng

        public int ID { set; get; }

        [Required]
        public string Name { set; get; }
        public virtual IEnumerable <Menu> Menus { set; get; }
    }
}