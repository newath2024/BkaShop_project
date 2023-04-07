using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BkaShop.Model.Models
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Column(TypeName = "varchar")] //chỉ ra chính xác kiểu dữ liệu của Alias
        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }
        public string Content { set; get; }
    }
}
