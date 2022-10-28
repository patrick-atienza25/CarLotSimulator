using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {

        }
        public int Year;
        public string Make;
        public string Model;
        public bool isDriveable;
        public string EngineNoise(string EngineNoise)
        {
            return EngineNoise;
        }
        public string HonkNoise(string HonkNoise)
        {
            return HonkNoise;
        }
    }
}
