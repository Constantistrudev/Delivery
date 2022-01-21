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
        public static int CountDeliveresPerDay(List<Deliverer> deliverers, DateTime date) //для графика день- количество заказов
        {
            int sum = 0;
            foreach (Deliverer deliverer in deliverers)
            {
                if (deliverer.WorkDay == date )
                {
                    sum += deliverer.AllOrders;
                }
            }
            return sum;
        }
        public static int CountOfOrders(List<Deliverer> deliverers) //для графика день- количество заказов
        {
            int sum = 0;
            foreach (Deliverer deliverer in deliverers)
            {
                    sum += deliverer.AllOrders;                
            }
            return sum;
        }
        public static int CountOfAllSucsessDeliveres(List<Deliverer> deliverers) // для кругового графика где показано отношение успешных и неуспешных заказов
        {
            int sum = 0;
            foreach (Deliverer deliverer in deliverers)
            {
                    sum += deliverer.NumberOfSucsessOrders;
            }
            return sum;
        }
        public static int CountOfAllCancledDeliveres(List<Deliverer> deliverers) 
        {
            int sum = 0;
            foreach (Deliverer deliverer in deliverers)
            {
                sum += deliverer.NumberOfCancledOrders;
            }
            return sum;
        }
        public static int CountOfAllDelivererWorkTime(List<Deliverer> deliverers,string delivererNumber)// для столбикового графика курьер-часы
        {
            int sum = 0;
            foreach (Deliverer deliverer in deliverers)
            {
                if (deliverer.DelivererNumber == delivererNumber)
                {
                    sum += deliverer.WorkTime;
                }
            }
            return sum;
        }
        public static double GetProfit(List<Deliverer> deliverers) //Общая приблыль
        {
            double sum = 0;
            foreach (Deliverer deliverer in deliverers)
            {
                    sum += deliverer.Profit;
            }
            return sum;
        }
        public static int GetAllPrice(List<Deliverer> deliverers) //Общая сумма заказа
        {
            int sum = 0;
            foreach (Deliverer deliverer in deliverers)
            {
                    sum += deliverer.AllOrderPrice;
            }
            return sum;
        }
        public static List<Deliverer> SortList(List<Deliverer> deliverers)
        {
            var NewListDeliverers = deliverers.GroupBy(g => g.DelivererNumber).OrderBy(g => g.Key).Select(g => new Deliverer
            {
            DelivererNumber = g.Key,
            WorkTime = g.Sum(deliverer => deliverer.WorkTime),
            Rating = g.Sum(deliverer => deliverer.Rating)
             }).ToList();
            return NewListDeliverers;
        }
        
    }
}
