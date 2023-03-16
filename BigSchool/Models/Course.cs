using System;
using System.ComponentModel.DataAnnotations;

namespace BigSchool.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string LectureId { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime Datetime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
}