using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace DataInteractions.Data.Entities

{
    public class InstructorAssignment
    {
        [Key, Column(Order = 0)]
        [ForeignKey(nameof(Cohort))]
        public int CohortId { get; set; }
        public virtual Cohort Cohort { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey(nameof(Instructor))]
        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }
        public virtual ICollection<InstructorAssignment>InstructorAssignments { get; set; } = new List<InstructorAssignment>();
    }
}