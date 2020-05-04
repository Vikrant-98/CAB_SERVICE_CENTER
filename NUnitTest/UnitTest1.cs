using NUnit.Framework;
using CAB_Services;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Given_Time_and_Travel_Distance_Normal_Fair()
        {
            CAB_Service service = new CAB_Service();
            int perKilometer = 10;
            int perminute = 1;
            int travel = service.RideKilometer(1, 40);
            int time = perminute * service.RideTime(1) * travel;
            int actual = time + travel * perKilometer;
            Assert.AreEqual(480 ,actual);
        }
        [Test]
        public void Given_Minimum_Ride_Normal_Fair()
        {
            CAB_Service service = new CAB_Service();
            int perKilometer = 10;
            int perminute = 1;
            int minimumCost = 5;
            int travel = service.RideKilometer(1,0);
            int time = perminute * service.RideTime(1) * travel;
            int actual = minimumCost;
            if (travel > 0)
            {
                actual = time + travel * perKilometer;
            }
            
            Assert.AreEqual(5, actual);
        }
        [Test]
        public void Given_Time_and_Travel_Distance_Primemium_Fair()
        {
            CAB_Service service = new CAB_Service();
            int perKilometer = 15;
            int perminute = 2;
            int travel = service.RideKilometer(1, 20);
            int time = perminute * service.RideTime(1) * travel;
            int actual = time + travel * perKilometer;
            Assert.AreEqual(380, actual);
        }
        [Test]
        public void Given_Minimum_Ride_Primemium_Fair()
        {
            CAB_Service service = new CAB_Service();
            int perKilometer = 15;
            int perminute = 2;
            int minimumCost = 20;
            int travel = service.RideKilometer(1, 0);
            int time = perminute * service.RideTime(1) * travel;
            int actual = minimumCost;
            if (travel > 0)
            {
                actual = time + travel * perKilometer;
            }

            Assert.AreEqual(20, actual);
        }
    }
}