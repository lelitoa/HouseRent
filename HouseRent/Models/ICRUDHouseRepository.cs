using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseRent.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace HouseRent.Models
{
    public interface ICRUDHouseRepository
    {
        House Add(House house);

        void Delete(int id);

        House Update(House house);

        House FindById(int id);

        IList<House> FindAll();
    }

    public class EFCRUDHouseRepository : ICRUDHouseRepository
    {
        private ApplicationDbContext context;

        public EFCRUDHouseRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public House Add(House house)
        {
            EntityEntry<House> entityEntry = context.House.Add(house);
            context.SaveChanges();
            return entityEntry.Entity;
        }

        public void Delete(int id)
        {
            context.House.Remove(context.House.Find(id));
            context.SaveChanges();
        }

        public IList<House> FindAll()
        {
            return context.House.ToList();
        }

        public House FindById(int id)
        {
            return context.House.Find(id);
        }


        public House Update(House house)
        {
            House original = context.House.Find(house.Id);
            original.Nazwa = house.Nazwa;
            original.Adres = house.Adres;
            original.Ilosc_osob = house.Ilosc_osob;
            original.Cena_za_dobe = house.Cena_za_dobe;
            EntityEntry<House> entityEntry = context.House.Update(original);
            context.SaveChanges();
            return entityEntry.Entity;
        }
    }
}
