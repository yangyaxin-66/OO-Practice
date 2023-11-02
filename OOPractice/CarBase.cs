namespace OOPractice
{
    public class CarBase
    {
        private string name = "Car";
        private int speed = 30;
        public CarBase(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public CarBase(string name, Engine engine)
        {
            this.name = name;
            this.speed = engine.Speed();
        }

        public string SpeedUp()
        {
            return $"{name}: speed up {speed} km/h";
        }
    }
}