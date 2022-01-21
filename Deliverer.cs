using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Delivery
{
    public class Deliverer
    {
        public string DelivererNumber { get; set; }
        public int NumberOfSucsessOrders { get; set; }
        public int NumberOfCancledOrders { get; set; }
        public int AverageDistanceTraveled { get; set; }
        public int AverageDeliveryTime { get; set; }
        public int AverageOrderPrice { get; set; }
        public int WorkTime { get; set; }
        public DateTime WorkDay { get; set; }
        public int HaveVehicle { get; set; }

        public int AllOrderPrice
            {
            get { return AverageOrderPrice * AllOrders; }
            }
        public double Profit
        {
            get { return 50 * AllOrders + AverageOrderPrice * NumberOfSucsessOrders * 0.2 - 110 * NumberOfSucsessOrders; }
        }
        public int AllOrders
        {
            get { return NumberOfSucsessOrders + NumberOfCancledOrders; }
        }
        public double Rating
        {
            get {return NumberOfSucsessOrders*0.05 - NumberOfCancledOrders*0.1;}
            set { }
        }

    }
}
