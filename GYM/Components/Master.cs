//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GYM.Components
{
    using System;
    using System.Collections.Generic;
    
    public partial class Master
    {
        public int id_employ { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Mail { get; set; }
        public string EName { get; set; }
        public Nullable<int> id_role { get; set; }
        public string id_client { get; set; }
    
        public virtual Rolee Rolee { get; set; }
    }
}
