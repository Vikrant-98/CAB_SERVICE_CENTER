using System;

namespace CAB_Services
{
    /// <summary>
    /// CAB Ride for Normal Passenger
    /// </summary>
    class Normal_CAB
    {
        readonly CAB_Service cab = new CAB_Service();
        static readonly public int perKilometer = 10;
        static readonly public int perminute = 1;
        static readonly public int minimumCost = 5;
        public Normal_CAB()
        {
            try { 
            Console.WriteLine("Enter No. of Passenger ");
            int user = int.Parse(Console.ReadLine());
            cab.Service(perKilometer, perminute, minimumCost,0,user);
            }
            catch (Exception message)
            {
                Console.WriteLine(message);
            }
        }
    }
}
