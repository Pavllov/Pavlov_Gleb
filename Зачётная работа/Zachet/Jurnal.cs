//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zachet
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jurnal
    {
        public int Id { get; set; }
        public Nullable<int> IdFIO { get; set; }
        public Nullable<int> IdDisceplina { get; set; }
        public Nullable<int> Mark { get; set; }
    
        public virtual Disceplina Disceplina { get; set; }
        public virtual FIO FIO { get; set; }
    }
}
