namespace SunLMS.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            QuestionAnswers = new HashSet<QuestionAnswer>();
        }

        [StringLength(50)]
        public string Id { get; set; }

        public string QName { get; set; }

        public int QLevel { get; set; }

        [StringLength(50)]
        public string QKind { get; set; }

        [Required]
        [StringLength(50)]
        public string QGroupCode { get; set; }

        [Required]
        [StringLength(50)]
        public string QAnswerType { get; set; }

        public string QImage { get; set; }

        public bool Active { get; set; }

        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ModifiedDate { get; set; }

        public virtual QuestionGroup QuestionGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; }
    }
}
