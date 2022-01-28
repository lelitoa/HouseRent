using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HouseRent.Models
{
    public class House
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Podaj nazwę! ")]
        [MinLength(5, ErrorMessage = "Nazwa powinna zawierać minimum 5 znaków. ")]
        public string Nazwa { get; set; }
        [Required(ErrorMessage = "Podaj adres! ")]
        [MinLength(7, ErrorMessage = "Adres powinień zawierać minimum 7 znaków. ")]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Podaj ilość osób! ")]
        public int Ilosc_osob { get; set; }
        [Required(ErrorMessage = "Podaj cenę! ")]
        public int Cena_za_dobe { get; set; }
        public House()
        {
                
        }
    }
}
