using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;



namespace Delivery
{
    public class DayInfo
    {
        public static int CountDeliveresPerDay(DateTime date, int allOrders) //для графика день- количество заказов
        {
            int sum = 0;
            foreach (Deliverer deliverer in Fileworker.Deliverers)
            {
                if (deliverer.WorkDay == date && deliverer.AllOrders == allOrders)
                {
                    sum += allOrders;
                }
            }
            return sum;
        }
        public static List<int> CountOfAllSucsessDeliveres(int numberOfSucsessOrders, int numberOfCancledOrders) // для кругового графика где показано отношение успешных и неуспешных заказов
        {
            int sucsessfulsum = 0;
            int canceledsum = 0;
            List<int> vs = new List<int>();
            foreach (Deliverer deliverer in Fileworker.Deliverers)
            {
                if (deliverer.NumberOfSucsessOrders == numberOfSucsessOrders && deliverer.NumberOfCancledOrders == numberOfCancledOrders)
                {
                    sucsessfulsum += numberOfSucsessOrders;
                    canceledsum += numberOfCancledOrders;
                }

            }
            vs.Add(sucsessfulsum);
            vs.Add(canceledsum);
            return vs;
        }
        public static int CountOfAllDelivererWorkTime(string delivererNumber, int workTime)// для столбикового графика курьер-часы
        {
            int sum = 0;
            foreach (Deliverer deliverer in Fileworker.Deliverers)
            {
                if (deliverer.DelivererNumber == delivererNumber && deliverer.WorkTime == workTime)
                {
                    sum += workTime;
                }
            }
            return sum;
        }
        public static double GetProfit(string delivererNumber, int profit) //Общая приблыль
        {
            double sum = 0;
            foreach (Deliverer deliverer in Fileworker.Deliverers)
            {
                if (deliverer.DelivererNumber == delivererNumber && deliverer.Profit == profit)
                {
                    sum += profit;
                }
            }
            return sum;
        }
        public static int GetAllPrice(string delivererNumber, int allOrderPrice) //Общая сумма заказа
        {
            int sum = 0;
            foreach (Deliverer deliverer in Fileworker.Deliverers)
            {
                if (deliverer.DelivererNumber == delivererNumber && deliverer.AllOrderPrice == allOrderPrice)
                {
                    sum += allOrderPrice;
                }
            }
            return sum;
        }

    }
}
