using System;

namespace CAB_Services
{
    class CAB_Service
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To CAB Service Center");
            NormalRide normal_fair = new NormalRide(10, 1, 5);
        }

        public double Ride(double totalFair, double perKilometer, double perMinute)
        {
            Random random = new Random();
            double passenger = random.Next();
            passenger = (passenger % 90) + 10;
            Console.WriteLine("Passenger travel " + passenger + " Kmtr");
            perMinute = perMinute + 1.5 * passenger;
            Console.WriteLine("Passenger travel " + perMinute + " Minutes");
            totalFair = passenger * perKilometer + perMinute;
            return totalFair;
        }
    }
    public class NormalRide
    {
        public NormalRide(double perKilometer, double perMinute, double minimumFair)
        {
            CAB_Service service = new CAB_Service();
            Console.WriteLine("Tolat fair of Passanger : " + service.Ride(minimumFair, perKilometer, perMinute));
        }
    }


}


