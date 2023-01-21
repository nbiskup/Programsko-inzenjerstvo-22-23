using Solid.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Model
{
    public class Employee : IRechargeable
    {
        private string name;
        private double salary;
        private double earnings;

        public double Salary { get => salary; set => salary = value; }

        public Employee(string name)
        {
            this.name = name;
            this.salary = 0.1;
        }

        public void CheckVehicle(Vehicle vehicle, Train train)
        {
            if (train.GetCapacity() > 0)
            {
                train.SetCapacity();
                earnings += vehicle.GetFare() * Salary;

                if (vehicle.GetGasSize() < Const.SIZE_LOW)
                {
                    Console.WriteLine(name + "'s " + vehicle.GetSizeType().ToString() + " gas size is " + vehicle.GetGasSize() + "% full");
                    Console.WriteLine("Gas is refilling...");
                    vehicle.SetGasSize();
                    Console.WriteLine(name + "'s " + vehicle.GetSizeType().ToString() + " gas size is " + vehicle.GetGasSize() + "% full");
                }

                if (vehicle.GetBatterySize() < Const.SIZE_LOW)
                {
                    Console.WriteLine(name + "'s " + vehicle.GetSizeType().ToString() + " battery size is " + vehicle.GetBatterySize() + "% full");
                    Console.WriteLine("Battery is refilling...");
                    vehicle.SetBatterySize();
                    Console.WriteLine(name + "'s " + vehicle.GetSizeType().ToString() + " battery size is " + vehicle.GetBatterySize() + "% full");

                }
            }
        }

        public string GetName() => name;

        public void GetEarnings() =>
            Console.WriteLine(name + "'s earnings are $" + earnings);

    }
}
