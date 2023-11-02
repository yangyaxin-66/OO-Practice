using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public interface Engine
    {
        public int Speed();
    }

    public class Gasline : Engine
    {
        public int Speed()
        {
            return 30;
        }
    }

    public class ElectricEngine : Engine
    {
        public int Speed()
        {
            return 25;
        }
    }
}
