using System;
namespace OOPractice
{
    public class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public string SpeedUp()
        {
            return $"{Name}:speed up {Speed} km/h";
        }
    }
}
