using Solid.Model;
using Solid.QA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terminal terminalSmallTrain = new Terminal(Train.Size.Small);
            Terminal terminalLargeTrain = new Terminal(Train.Size.Large);

            Employee employeeSmallTrain = new EmployeeBuilder("TopG").Build();
            Employee employeeLargeTrain = new EmployeeBuilder("Brokey").SetSalary(0.11).Build();


            Vehicle car = new Vehicle(Vehicle.Type.Car, 40, 5);
            Vehicle van = new Vehicle(Vehicle.Type.Car, 8, 50);
            Vehicle bus = new Vehicle(Vehicle.Type.Bus, 20, 30);
            Vehicle truck = new Vehicle(Vehicle.Type.Truck, 5, 30);

            terminalSmallTrain.ParkVehicle(car, employeeSmallTrain);
            terminalSmallTrain.ParkVehicle(van, employeeSmallTrain);
            terminalLargeTrain.ParkVehicle(bus, employeeLargeTrain);
            terminalLargeTrain.ParkVehicle(truck, employeeLargeTrain);

            terminalSmallTrain.GetTicketEarnings();
            terminalLargeTrain.GetTicketEarnings();

            Console.WriteLine();

            employeeSmallTrain.GetEarnings();
            employeeLargeTrain.GetEarnings();

            Console.WriteLine();

            Test test = new Test();
            test.TestTrainSize();
        }
    }
}
