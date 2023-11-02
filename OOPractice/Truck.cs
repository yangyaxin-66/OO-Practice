using System;
namespace OOPractice
{
    public class Truck : CarBase
    {
        public Truck(string name, int speed) : base(name, speed)
        {
        }

        public Truck(string name, Engine engine) : base(name, engine)
        {
        }
    }
}