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
            int sum = deliverers.Where(d => d.WorkDay == date)
                .Sum(d => d.AllOrders);

            return sum;
        }
        public static int CountOfOrders(List<Deliverer> deliverers) //для графика день- количество заказов
        {
            int sum = deliverers.Sum(d => d.AllOrders);
            return sum;
        }
        public static int CountOfAllSucsessDeliveres(List<Deliverer> deliverers) // для кругового графика где показано отношение успешных и неуспешных заказов
        {
            int sum = deliverers.Sum(d => d.NumberOfSucsessOrders);
            return sum;
        }
        public static int CountOfAllCancledDeliveres(List<Deliverer> deliverers) 
        {
            int sum = deliverers.Sum(d => d.NumberOfCancledOrders);
            return sum;
        }
        public static int CountOfAllDelivererWorkTime(List<Deliverer> deliverers,string delivererNumber)// для столбикового графика курьер-часы
        {
            int sum = deliverers.Where(d => d.DelivererNumber == delivererNumber)
                .Sum(d => d.WorkTime);

            return sum;
        }
        public static decimal GetProfit(List<Deliverer> deliverers) //Общая приблыль
        {
            decimal sum = deliverers.Sum(d => d.Profit);
            return sum;
        }
        public static decimal GetAllPrice(List<Deliverer> deliverers) //Общая сумма заказа
        {
            decimal sum = deliverers.Sum(d => d.AllOrderPrice);
            return sum;
        }
        public static List<Deliverer> SortList(List<Deliverer> deliverers)
        {
            var NewListDeliverers = deliverers.GroupBy(g => g.DelivererNumber)
                            .OrderBy(g => g.Key)
                            .Select(g => new Deliverer
                            {
                                DelivererNumber = g.Key,
                                WorkTime = g.Sum(deliverer => deliverer.WorkTime),
                                NumberOfSucsessOrders = g.Sum(deliverer => deliverer.NumberOfSucsessOrders),
                                NumberOfCancledOrders = g.Sum(deliverer => deliverer.NumberOfCancledOrders)
                            }).ToList();
            return NewListDeliverers;
        }
        public static IEnumerable<(DateTime WorkDay, int AllOrders)> LineGraphic(List<Deliverer> deliverers)
        {
            var NewListDeliverers = deliverers.GroupBy(deliverer => deliverer.WorkDay.Date)
                .Select(d => (Date: d.Key, AllOrders: d.Sum(x=>x.AllOrders)));
            return NewListDeliverers;
        }
    }
}
