//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reader()
        {
            this.BookReaders = new HashSet<BookReader>();
        }
    
        public int iD { get; set; }
        public string Rnm { get; set; }
        public string RSnm { get; set; }
        public string Rphon { get; set; }
        public Nullable<int> Rfk { get; set; }
        public int Rtno { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookReader> BookReaders { get; set; }
        public virtual Fakulteler Fakulteler { get; set; }
    }
}