namespace SunLMS.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuestionAnswer")]
    public partial class QuestionAnswer
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string QuestionId { get; set; }

        public int? AnswerOrder { get; set; }

        public string AnswerContent { get; set; }

        public bool IsCorrect { get; set; }

        public string AImage { get; set; }

        public double? SurveyScore { get; set; }

        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ModifiedDate { get; set; }

        public virtual Question Question { get; set; }
    }
}
