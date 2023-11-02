using System;
namespace OOPractice
{
    public class Car : CarBase
    {
        public Car(string name, int speed) : base(name, speed)
        {
        }

        public Car(string name, Engine engine) : base(name, engine)
        {
        }
    }
}