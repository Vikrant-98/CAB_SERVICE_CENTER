using System;

namespace CAB_Services
{
    /// <summary>
    /// CAB Ride for Primemium Passenger
    /// </summary>
    class Primemium_CAB
    {
        readonly CAB_Service cab = new CAB_Service();
        static readonly public int perKilometer = 15;
        static readonly public int perminute = 2;
        static readonly public int minimumCost = 20;
        public Primemium_CAB()
        {
            try
            {
                Console.WriteLine("Enter No. of Passenger ");
                int user = int.Parse(Console.ReadLine());
                cab.Service(perKilometer, perminute, minimumCost, 0, user);
            }
            catch (Exception message)
            {
                Console.WriteLine(message);
            }
        }
    }
}
