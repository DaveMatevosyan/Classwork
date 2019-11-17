using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleShop
{
    class Bus : Vehicle, IRentable
    {
        public double RentPrice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Duration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override double MaxSpeed => throw new NotImplementedException();

        public void Rent()
        {
            throw new NotImplementedException();
        }

        public override void Tune()
        {
            throw new NotImplementedException();
        }
    }
}
