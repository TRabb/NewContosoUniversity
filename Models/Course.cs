using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        [Required]
        [ConcurrencyCheck]
        [MaxLength(24, ErrorMessage = "The maximum length is 24 characters")]
        [MinLength(5, ErrorMessage = "The minimum length is 5 characters")]
        [Index(IsUnique = true)]
        public string Title { get; set; }
        [Range(1, 6)]
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}