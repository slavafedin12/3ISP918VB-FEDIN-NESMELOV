//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _3ISP918VB_FEDIN_NESMELOV.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int IdProd { get; set; }
        public string ProdName { get; set; }
        public int IdProdType { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public short Quantity { get; set; }
    
        public virtual ProdShop ProdShop { get; set; }
    }
}
