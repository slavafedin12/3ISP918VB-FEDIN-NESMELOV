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
    
    public partial class Shopping
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shopping()
        {
            this.Basket = new HashSet<Basket>();
        }
    
        public int ID { get; set; }
        public int ClientId { get; set; }
        public float StartTime { get; set; }
        public int EmployeeId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Basket> Basket { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ProdShop ProdShop { get; set; }
    }
}