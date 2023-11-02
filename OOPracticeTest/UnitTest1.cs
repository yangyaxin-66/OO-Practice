using OOPractice;
using Xunit;
namespace OOPracticeTest
{
    public class UnitTest1
    {
        [Fact]
        public void Shoule_return_name_and_speed_When_speedup_Given_nameandspeed()
        {//GIVEN
            Car car = new Car(); //构造方法
            car.Name = "Big truck";
            car.Speed = 10;
            //WHEN
            string result = car.SpeedUp();
            //THEN
            Assert.Equal("Big truck:speed up 10 km/h", result);
        }
    }
}
