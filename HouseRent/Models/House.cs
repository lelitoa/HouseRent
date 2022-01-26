using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseRent.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Adres { get; set; }
        public int Ilosc_osob { get; set; }
        public int Cena_za_dobe { get; set; }
        public House()
        {
                
        }
    }
}
