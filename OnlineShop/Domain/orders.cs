//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class orders
    {
        public int Order_id { get; set; }
        public int Client_id { get; set; }
        public int Product_id { get; set; }
        public System.DateTime Add_date { get; set; }
    
        public virtual users users { get; set; }
        public virtual products products { get; set; }
    }
}
