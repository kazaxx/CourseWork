//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KursWork_EuroBild_.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class customers_order
    {
        public int ID_Сustomers_order { get; set; }
        public Nullable<int> ID_customers { get; set; }
        public Nullable<int> Manager_ID { get; set; }
        public Nullable<int> Foreman_ID { get; set; }
        public string Project_Name { get; set; }
        public string Construction_Status { get; set; }
        public Nullable<System.DateTime> Date_Start { get; set; }
        public Nullable<System.DateTime> Date_Ending { get; set; }
        public string Price { get; set; }
    
        public virtual customers customers { get; set; }
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
    }
}
