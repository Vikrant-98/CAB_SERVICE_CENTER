using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CAB_Services
{
    class CAB_Service
    {
        readonly Random random = new Random();                                              //Random class created for Example Entries

        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome To CAB Service ");
            Normal_CAB normal = new Normal_CAB();
            Primemium_CAB prime = new Primemium_CAB();
           
        }
        /// <summary>
        /// Calculationg the total cost of passenger as well as average of total cost
        /// </summary>
        /// <param name="perKilometer"></param>
        /// <param name="perMinute"></param>
        /// <param name="minimumCost"></param>
        /// <param name="passenger"></param>
        public void Service(int perKilometer , int perMinute , int minimumCost , int passenger , int user)
        {
            double total = 0, average = 0;
            List<InvokeCAB> cab = new List<InvokeCAB>();
            CAB_Service obj = new CAB_Service();
            while (passenger != user)
            {
                double travel = obj.RideKilometer(passenger++);
                double cost = minimumCost;
                if (travel > 0)
                {
                    cost = obj.RideTime(perMinute) * travel;
                }
                InvokeCAB cabEntry = new InvokeCAB
                {
                    PassengerTravel = travel,                                           // Travel Distance added
                    PassengerTotalCost = cost + travel * perKilometer                   // Travel cost addde
                };
                total = total + cabEntry.PassengerTotalCost;
                cab.Add(cabEntry);
            }
            string str = JsonConvert.SerializeObject(cab, Formatting.Indented);
            Console.WriteLine(str);
            average = total / passenger;                                                // Calculating the average of total Passenger
            Console.WriteLine("Average Fare Per Ride is : " + average);
        }
        /// <summary>
        /// Calculating the total time spend by passenger for perticular Ride
        /// </summary>
        /// <param name="perMinute"></param>
        /// <returns> Time spend by the passenger </returns>
        public int RideTime(int perMinute)
        {
            int passengerTravelTime = perMinute * (random.Next() % 3 + 1);
            return passengerTravelTime;                                                //Return Time travelled
        }
        /// <summary>
        /// Calculating the total kilometer travel by the passenger for that Ride
        /// </summary>
        /// <param name="passenger"></param>
        /// <returns> Travel by the passenger </returns>
        public int RideKilometer(int passenger)
        {
            int passengerKilometer = random.Next();
            passengerKilometer = passengerKilometer % 100;
            return passengerKilometer;                                                  //Return Distance travelled
        }
        
    }
}