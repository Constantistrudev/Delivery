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
        public bool HaveVehicle { get; set; }

        public decimal AllOrderPrice
            {
            get { return AverageOrderPrice * AllOrders; }
            }
        decimal profit = 0;
        public decimal   Profit
        {
            get { return  profit=50M * AllOrders + AverageOrderPrice * NumberOfSucsessOrders * 0.2M - 110 * NumberOfSucsessOrders; }
        }
        public int AllOrders
        {
            get { return NumberOfSucsessOrders + NumberOfCancledOrders; }
        }
        public double Rating
        {
            get { return NumberOfSucsessOrders * 0.05 - NumberOfCancledOrders * 0.1; }
        }
    }
}
