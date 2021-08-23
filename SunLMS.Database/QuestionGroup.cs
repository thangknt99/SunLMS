namespace SunLMS.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuestionGroup")]
    public partial class QuestionGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuestionGroup()
        {
            Questions = new HashSet<Question>();
        }

        [Key]
        [StringLength(50)]
        public string QGroupCode { get; set; }

        [Required]
        [StringLength(200)]
        public string QGroupName { get; set; }

        public string CostcenterAvailable { get; set; }

        [StringLength(50)]
        public string QGroupKind { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        [StringLength(50)]
        public string PermissionType { get; set; }

        public string PermissionUsers { get; set; }

        public bool Active { get; set; }

        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ModifiedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }
    }
}
