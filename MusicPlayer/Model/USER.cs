//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicPlayer.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            this.LASTESTs = new HashSet<LASTEST>();
            this.SONGs = new HashSet<SONG>();
            this.UPLOADSONGs = new HashSet<UPLOADSONG>();
            this.PLAYLISTs = new HashSet<PLAYLIST>();
            this.UPLOADVIDEOs = new HashSet<UPLOADVIDEO>();
        }
    
        public int USERID { get; set; }
        public string FULLNAME { get; set; }
        public string USERNAME { get; set; }
        public string PASS { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string SEX { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LASTEST> LASTESTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SONG> SONGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UPLOADSONG> UPLOADSONGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLAYLIST> PLAYLISTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UPLOADVIDEO> UPLOADVIDEOs { get; set; }
    }
}