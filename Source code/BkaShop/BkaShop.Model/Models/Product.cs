﻿using BkaShop.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace BkaShop.Model.Models
{
    [Table("Products")] //bảng truyền dữ liệu vào
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //ID sẽ tự tăng

        public int ID { set; get; }
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }
        public int CatagoryID { set; get; }
        public string Image { set; get; }
        public XElement MoreImages { set; get; }
        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }
        public string Descripsion { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
        [ForeignKey("CategoryID")] // trường tham chiếu CategoryID
        public virtual ProductCategory ProductCategory { set; get; }
    }
}