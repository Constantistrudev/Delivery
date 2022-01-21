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
        
        // В каких единицах измеряется, что значение целочисленное, в метрах? 
        public int AverageDistanceTraveled { get; set; }
        public int AverageDeliveryTime { get; set; }
        public int AverageOrderPrice { get; set; }
        public int WorkTime { get; set; }
        public DateTime WorkDay { get; set; }
        

        // Если тут имеется да или нет, то спешу познакомить тебя с таким типом данных как bool, на втором курсе это даже не смешно
        public int HaveVehicle { get; set; }

        // И снова не умеет в тмпы данных... Стоит дальше проверять?
        // И кто тебя так код форматировать учил... 
        public int AllOrderPrice
            {
            get { return AverageOrderPrice * AllOrders; }
            }
        // Ага а здесь практическ правилный тип данных, но для денег используется decimal
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
            // Это то срань?
            set { }
        }

    }
}
