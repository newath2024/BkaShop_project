using System;
using System.ComponentModel.DataAnnotations;

namespace BkaShop.Model.Abstract
{
    //tạo lớp ảo để kế thừa
    public abstract class Auditable : IAuditable
    {
        public DateTime CreatedDate { set; get; }

        [MaxLength(256)]
        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }

        [MaxLength(256)]
        public string UpdatedBy { set; get; }
        [MaxLength(256)]
        public string MetaKeyword { set; get; }
        [MaxLength(256)]

        public string MetaDecripsion { set; get; }
        public bool Status { set; get; }

    }
}