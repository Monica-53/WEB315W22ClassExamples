using System;
using System.ComponentModel.DataAnnotations;

namespace ClassExampleRazorPages.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }

        [DataType(DataType.Date)]
        public DateTime CarYearReleased { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }
}