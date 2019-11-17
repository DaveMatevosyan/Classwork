using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleShop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Bike() { Model = "BMX", Year = 2005, IsRentable = true });
            vehicles.Add(new Car() { Model = "BMW", Year = 2009, IsRentable = true });
            vehicles.Add(new Car() { Model = "Nissan", Year = 2010, IsRentable = false });

            foreach (var item in vehicles)
            {
                Console.WriteLine($"{item.Model}, {item.Year}");
            }
            var rentables = GetRentableVehicles(vehicles);

            Console.WriteLine("Rentable vehicles");
            foreach (var item in rentables)
            {
               // Console.WriteLine($"{item.Model}, {item.Year}");
                Console.WriteLine($"{item.RentPrice}, {item.Duration}");
            }

            Car myCar = new Car("Toyota", 2019);
            
            List<Bike> bikes = new List<Bike>();
            bikes.Add(new Bike() {Model = "BMX", Year = 2005, IsRentable = true });
            bikes.Add(new Bike() { Model = "Trek", Year = 2010, IsRentable = false });

            Car[] cars = new Car[3];
            cars[0] = (new Car() { Model = "BMW", Year = 2009, IsRentable = true });
            cars[1] = (new Car() { Model = "Nissan", Year = 2019, IsRentable = false });
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
            Car bmwCar = new Car() { Model = "BMW", Year = 2009, IsRentable = true };
            foreach (var item in bmwCar)
            {
                Console.WriteLine(item);
            }

            foreach (var item in bmwCar)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static List<IRentable> GetRentableVehicles(List<Vehicle> vehicles)
        {
            List<IRentable> rentableVehicles = new List<IRentable>();
            foreach (var item in vehicles)
            {
                var a = item as IRentable;
                //if(a != null)
                //{

                //}
                if (item is IRentable rentable)
                {
                    rentableVehicles.Add(rentable);
                }
                //if(item.IsRentable)
                //{
                //    rentableVehicles.Add(item);
                //}
            }
            return rentableVehicles;
        }


    }
}
