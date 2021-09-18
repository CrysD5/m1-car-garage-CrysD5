using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int FuelLevel { get; set; }
        public bool AutoBrakeActive { get; set; }

        public void SetMake(string make)
        {
            this.Make = make;
        }

        public void SetModel(string model)
        {
            this.Model = model;
        }

        public int GetSpeed() => this.Speed;

        public bool IsSpeeding()
        {
            return Speed > 70;
        }

        public int Accelerate()
        {
            if (Make == "Ferrari" && Speed < 100)
                {
                return Speed += 20;
            }
            else if (Speed < 100)
            {
                return Speed += 10;
            }
            else
            {
                return Speed;
            }
         }

        public int Brake()
        {
            if(Speed >= 7 && AutoBrakeActive)
            {
                return Speed /= 2;
            }
            else if(Speed >= 7 && !AutoBrakeActive)
            {
                return Speed -= 7;
            }
            else
            {
                return Speed = 0;
            }
        }
        
            
        public bool AutoBreakActive() => true;
    }

}
