using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleShop
{
    class Car : Vehicle, IEnumerable
    {
        public override double MaxSpeed => 200.0;
        private  CarPart[] parts;

        public Car()
        {
            parts = new CarPart[3] {
            new CarPart() { Name = "Engine", Used = 70 },
                new CarPart() { Name = "Wheels", Used = 10 },
                new CarPart() { Name = "Salon", Used = 30 },
            };
    }
        public Car(string model, int year)
        {
            this.Model = model;
            this.Year = year;
            
        }
        public override void Tune()
        {
            Console.WriteLine($"{this.Model} is tuned");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //return parts.GetEnumerator();
            return (IEnumerator)GetEnumerator();
            //return new CarPartsEnumerator(this.parts);
        }

        CarPartsEnumerator GetEnumerator()
        {
            return new CarPartsEnumerator(parts);
        }     
    }

    class CarPartsEnumerator : IEnumerator
    {
        public CarPart[] parts;
        int position = -1;
        public CarPartsEnumerator(CarPart[] carParts)
        {
            this.parts = carParts;
        }
        public object Current => parts[position];

        public bool MoveNext()
        {
            position++;
            return position < parts.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }

    class CarPart
    {
        public string Name { get; set; }
        public int Used { get; set; }
        public override string ToString()
        {
            return $"{this.Name}, {this.Used}";
        }
    }
}
