using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleShop
{
    abstract class Vehicle
    {
        public abstract double MaxSpeed { get; }
        public bool IsRentable { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Capacity { get; set; }
        public double Speed { get; set; }
        public abstract void Tune();
        public virtual void SpeedUp(int speed)
        {
            this.Speed += speed;
        }
    }
}
