using System;
using System.ComponentModel.DataAnnotations;

namespace ThermometersMvc.Models
{
    public class Thermometers
    {
        public int Id { get; set; }
        public string TypeOfThermometer { get; set; }
        public decimal TemperatureRange { get; set; }
        public string ProbeType { get; set; }
        public string Accuracy { get; set; }
        public decimal Price { get; set; }
        public string Display { get; set; }
        public string Rating { get; set; }
    }
}