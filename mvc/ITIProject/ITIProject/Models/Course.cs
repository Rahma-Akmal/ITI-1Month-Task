using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ITIProject.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        [Range(30,60)]
        public int CourseDuration {  get; set; }
        [ValidateNever]
        public List<Student> Students { get; set; }

    }
}
