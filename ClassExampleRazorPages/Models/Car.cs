using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassExampleRazorPages.Models
{
    public class Car
    {
        public int ID { get; set; }

        [Display(Name = "Make")]
        public string CarMake { get; set; }

        [Display(Name = "Model")]
        public string CarModel { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime CarYearReleased { get; set; }
        public string Color { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string OwnerName { get; set; }
    }
}