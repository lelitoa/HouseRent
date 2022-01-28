using System;
using Xunit;
using HouseRent.Controllers;
using HouseRent.Models;
using Moq;

namespace HouseRentTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ICRUDHouseRepository _houseList = new HouseRepository();
            //HousesController controller = new HousesController(_houseList);
            CreateViewModel viewModel = new CreateViewModel();
            Assert.NotNull(viewModel);
        }
        //[Fact]
        //public void TestAdd()
        //{
        //    ICRUDHouseRepository house = new HouseRepository();
        //    HousesController controller = new HousesController(house);
        //    controller.Create(new CreateViewModel() { Id = 5, Nazwa = "Willa nad jeziorem", Adres = "ul. nad jeziorem", Ilosc_osob = 8, Cena_za_dobe = 5000 });
        //}
        //[Fact]
        //public void TestAddForm()
        //{
        //    var mock = new Mock<ICRUDHouseRepository>();

        //    var controller = new HousesController(mock.Object);
        //    var res = controller.Create(new CreateViewModel() { Id = 1 });

        //    mock.Verify(v => v.Add(It.IsAny<House>()));
        //}
        //[Fact]
        //public void TestDelete()
        //{
        //    var house = new House() { Id = 1 };

        //    var mock = new Mock<ICRUDHouseRepository>();
        //    var controller = new HousesController(mock.Object);
        //    var res = controller.Delete(1);

        //    mock.Verify(v => v.Delete(1), Times.Once());
        //}

        //[Fact]
        //public void TestUpdate()
        //{
        //    var house = new House() { Id = 1 };
        //    var house2 = new EditViewModel() { Id = 1 };
        //    var mock = new Mock<ICRUDHouseRepository>();
        //    mock.Setup(v => v.FindById(1)).Returns(house);
        //    var controller = new HousesController(mock.Object);

        //    var res = controller.Edit(house2.Id);

        //    mock.Verify(v => v.Update(It.IsAny<House>()), Times.Once());
        //}
    }
}
