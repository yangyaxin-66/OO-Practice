namespace OOPractice
{
    public class CarBase
    {
        private string name = "Car";
        private int speed = 30;

        public CarBase()
        {
        }

        public CarBase(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string SpeedUp()
        {
            return $"{name}: speed up {speed} km/h";
        }
    }
}