//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EuroBuld.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer_orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer_orders()
        {
            this.Processed_customer_orders = new HashSet<Processed_customer_orders>();
        }
    
        public int ID_Customers_orders { get; set; }
        public Nullable<int> ID_Service { get; set; }
        public Nullable<int> ID_Users { get; set; }
        public Nullable<System.DateTime> Order_Date { get; set; }
        public string Status { get; set; }
    
        public virtual Service Service { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Processed_customer_orders> Processed_customer_orders { get; set; }
    }
}
