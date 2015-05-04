namespace BugNET.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BugNet_RelatedIssues")]
    public partial class RelatedIssue
    {
        [Key]
        [Column("PrimaryIssueId", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParentIssueId { get; set; }

        [Key]
        [Column("SecondaryIssueId", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChildIssueId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RelationType { get; set; }

        public virtual Issue ParentIssue { get; set; }

        public virtual Issue ChildIssue { get; set; }
    }
}
