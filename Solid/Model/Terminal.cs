using Solid.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Model
{
    public class Terminal : IParkable
    {
        private Train smallTrain;
        private Train largeTrain;
        private int ticketEarnings = Const.ZERO;

        public Terminal(Train.Size trainSize)
        {
            if (trainSize == Train.Size.Small)
                smallTrain = new Train(trainSize);
            else
                largeTrain = new Train(trainSize);             
        }

        public void ParkVehicle(Vehicle vehicle, Employee employee)
        {
            if (vehicle.GetSizeType() == Vehicle.Type.Car || vehicle.GetSizeType() == Vehicle.Type.Van)
                employee.CheckVehicle(vehicle, smallTrain);

            else
                employee.CheckVehicle(vehicle, largeTrain);

            ticketEarnings += vehicle.GetFare();
            Console.WriteLine();
        }

        public void GetTicketEarnings() => Console.WriteLine("Total earnings from tickets at this terminal is $" + ticketEarnings);


    }
}
