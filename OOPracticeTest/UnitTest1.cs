using OOPractice;
using Xunit;
namespace OOPracticeTest
{
    public class UnitTest1
    {
        [Fact]
        public void Shoule_return_name_and_speed_When_speedup_Given_nameandspeed()
        {//GIVEN
            Car car = new Car("Cool", 30);
            //car.Name = "Big truck";
            //car.Speed = 10;
            //WHEN
            string result = car.SpeedUp();
            //THEN
            Assert.Equal("Cool: speed up 30 km/h", result);
        }

        [Fact]
        public void Shoule_return_drive_name_and_speed_When_speedup_Given_nameandspeed()
        {
            //Given
            Car car = new Car("Cool", 30);
            Driver driver = new Driver();
            //when
            string result = driver.Drive(car);
            //then
            Assert.Equal("Cool: speed up 30 km/h", result);
        }

        [Fact]
        public void Shoule_return_drive_truck_name_and_speed_When_speedup_Given_nameandspeed()
        {
            //Given
            Truck truck = new Truck("Big Truck", 10);
            Driver driver = new Driver();
            //when
            string result = driver.Drive(truck);
            //then
            Assert.Equal("Big Truck: speed up 10 km/h", result);
        }

        [Fact]
        public void Shoule_return_drive_engine_name_and_speed_When_speedup_Given_nameandspeed()
        {
            //Given
            Truck truck = new Truck("Big Truck", 10);
            Driver driver = new Driver();
            //when
            string result = driver.Drive(truck);
            //then
            Assert.Equal("Big Truck: speed up 10 km/h", result);
        }

        [Fact]
        public void Shoule_return_speed_engine_name_and_speed_When_speedup_Given_nameandspeed()
        {
            ElectricEngine engineType = new ElectricEngine();
            Truck truck = new Truck("Small Truck", engineType.Speed());
            Driver driver = new Driver();
            //when
            string result = driver.Drive(truck);
            //then
            Assert.Equal("Small Truck: speed up 30 km/h", result);
        }
    }
}