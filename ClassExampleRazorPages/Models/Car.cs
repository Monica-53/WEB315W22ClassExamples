using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassExampleRazorPages.Models
{
    public class Car
    {
        public int ID { get; set; }

        [StringLength(31, MinimumLength = 3)]
        [Required]
        [Display(Name = "Make")]
        public string CarMake { get; set; }

        [StringLength(63, MinimumLength = 3)]
        [Required]
        [Display(Name = "Model")]
        public string CarModel { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CarYearReleased { get; set; }

        [RegularExpression(@"^[a-zA-Z\s-]+$"), Required, StringLength(31)]
        public string Color { get; set; }

        [Range(1, 100000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        // [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(63)]
        public string OwnerName { get; set; }
    }
}