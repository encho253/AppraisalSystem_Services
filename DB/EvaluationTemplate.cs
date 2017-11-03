//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    [DataContract]
    public partial class EvaluationTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EvaluationTemplate()
        {
            this.Evaluations = new HashSet<Evaluation>();
            this.Questions = new HashSet<Question>();
        }
    
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int QualificationId { get; set; }

        [DataMember]
        public byte[] ExcelTemplate { get; set; }

        [DataMember]
        public byte[] ExcelDataMapping { get; set; }

        [DataMember]
        public string Name { get; set; }
    
        [IgnoreDataMember]
        public virtual Position Position { get; set; }

        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluation> Evaluations { get; set; }

        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }
    }
}
