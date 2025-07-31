using System;
using System.ComponentModel.DataAnnotations;

namespace CraftCourses.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "اسم الدورة")]
        public string Title { get; set; }

        [Display(Name = "وصف الدورة")]
        public string Description { get; set; }

        [Display(Name = "اسم المدربة")]
        public string Instructor { get; set; }

        [Display(Name = "التصنيف")]
        public string Category { get; set; }

        [Display(Name = "السعر")]
        [Range(1, 1000)]
        public decimal Price { get; set; }

        [Display(Name = "تاريخ البدء")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "رابط الصورة")]
        public string ImageUrl { get; set; }
    }
}
