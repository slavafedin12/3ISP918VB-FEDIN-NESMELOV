//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _3ISP918VB_FEDIN_NESMELOV
{
    using System;
    using System.Collections.Generic;
    
    public partial class Basket
    {
        public int ID { get; set; }
        public int ClientId { get; set; }
        public int ProdId { get; set; }
    
        public virtual Shopping Shopping { get; set; }
    }
}
