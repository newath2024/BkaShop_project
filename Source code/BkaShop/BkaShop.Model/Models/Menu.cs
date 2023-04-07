using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BkaShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //ID sẽ tự tăng

        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string URL { set; get; }

        public int? DisplayOrder { set; get; } // cho phép null

        [Required]
        public int GroupID { set; get; }
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; } //khóa ngoại

        public string Target { set; get; }

        [Required]
        public bool Status { set; get; }
    }
}