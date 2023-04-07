using System;

namespace BkaShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }
        string MetaKeyword { set; get; }
        string MetaDecripsion { set; get; }
        bool Status { set; get; }

    }
}