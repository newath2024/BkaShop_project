using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BkaShop.Model
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //ID sẽ tự tăng

        public string ID { set; get; }

        [Required]
        public string Content { set; get; }
    }
}