using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BkaShop.Model
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //ID sẽ tự tăng
        [MaxLength(50)]
        public string ID { set; get; }

        [Required] // không cho phép null
        public string Content { set; get; }
    }
}