//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tournament_420_SkrylevaLianaAleksandrovna.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Statistic
    {
        public int id { get; set; }
        public Nullable<int> victoryCount { get; set; }
        public Nullable<int> defeatCount { get; set; }
        public Nullable<int> countPlay { get; set; }
        public Nullable<int> idUser { get; set; }
    
        public virtual Participant Participant { get; set; }
    }
}