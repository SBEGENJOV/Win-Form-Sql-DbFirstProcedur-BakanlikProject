//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bakanlik
{
    using System;
    using System.Collections.Generic;
    
    public partial class bakanlik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bakanlik()
        {
            this.vergilers = new HashSet<vergiler>();
        }
    
        public int bakanlikID { get; set; }
        public string bakanlikAdi { get; set; }
        public string daireBaskani { get; set; }
        public Nullable<decimal> bakanlikCiro { get; set; }
        public string BakanlikMerkez { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vergiler> vergilers { get; set; }
    }
}
