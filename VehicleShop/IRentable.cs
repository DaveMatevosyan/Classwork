using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleShop
{
    interface IRentable
    {
        double RentPrice { get; set; }
        int Duration { get; set; }
        void Rent();
    }
}
