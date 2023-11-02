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
            //when
            string result = car.Drive();

            Assert.Equal("Cool: speed up 30 km/h", result);
        }
    }
}
