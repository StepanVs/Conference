//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Performance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Performance()
        {
            this.PerfAndSpeakers = new ObservableListSource<PerfAndSpeaker>();
        }
    
        public int idPerf { get; set; }
        public int idSect { get; set; }
        public string topicrf { get; set; }
        public System.DateTime datetimePerf { get; set; }
        public System.TimeSpan durationPerf { get; set; }
        public Nullable<int> IdEquip { get; set; }
    
        public virtual Equipment Equipment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<PerfAndSpeaker> PerfAndSpeakers { get; set; }
        public virtual Section Section { get; set; }
    }
}
