//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ado_06_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeachersGroups
    {
        public int Id { get; set; }
        public Nullable<int> IdTeacher { get; set; }
        public Nullable<int> IdGroup { get; set; }
        public Nullable<int> IdSubject { get; set; }
    
        public virtual Groups Groups { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
