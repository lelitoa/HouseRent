using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseRent.Models;

namespace HouseRentTests
{
    internal class HouseRepository : ICRUDHouseRepository
    {
        private List<House> _houseList;

        public HouseRepository()
        {
            _houseList = new List<House>()
            {
                new House(){Id=1, Nazwa="Test1", Adres="ul. test1", Ilosc_osob=5, Cena_za_dobe=2500},
                new House(){Id=1, Nazwa="Test2", Adres="ul. test2", Ilosc_osob=10, Cena_za_dobe=5000},
            };
        }
        public House Add(House house)
        {
            house.Id = _houseList.Max(e => e.Id) + 1;
            _houseList.Add(house);
            return house;
        }

        public void Delete(int id)
        {
            House house = _houseList.FirstOrDefault(e => e.Id == id);
            if (house != null)
            {
                _houseList.Remove(house);
            }
        }

        public IList<House> FindAll()
        {
            return _houseList;
        }

        public House FindById(int id)
        {
            return _houseList.FirstOrDefault(e => e.Id == id);
        }


        public House Update(House house)
        {
            House original = _houseList.FirstOrDefault(e => e.Id == house.Id);
            if (house != null)
            {
                original.Nazwa = house.Nazwa;
                original.Adres = house.Adres;
                original.Ilosc_osob = house.Ilosc_osob;
                original.Cena_za_dobe = house.Cena_za_dobe;
            }
            return original;
        }

    }
}
