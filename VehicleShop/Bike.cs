using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleShop
{
    class Bike : Vehicle, IRentable
    {
        public override double MaxSpeed
        {
            get => 100.0;
        }

        private double rentPrice;
        public double RentPrice
        {
            get => this.rentPrice;
            set => this.rentPrice = value;
        }

        private int duration;
        public int Duration
        {
            get => this.duration;
            set => this.duration = value;
        }

        public Bike()
        {

        }
        public Bike(string model, int year)
        {
            this.Model = model;
            this.Year = year;
        }
        public override void Tune()
        {
            this.Color = "Yellow";
            Console.WriteLine($"{this.Model} is tuned.");
        }

        public override void SpeedUp(int speed)
        {
            base.SpeedUp(speed);
        }

        public bool IsHealthy()
        {
            return true;
        }

        public void Rent()
        {
            throw new NotImplementedException();
        }
    }
}
