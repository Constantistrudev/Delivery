using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text.Unicode;


namespace Delivery
{
    public class Fileworker
    {
        public static string WorkPath { get; set; }
        public static List<Deliverer> Deliverers = new List<Deliverer>();
        public static List<Deliverer> TableofDeliveres = new List<Deliverer>();
        public static void AddDeliverer(string delivererNumber, int numberOfSucsessOrders, int namberOfCanceledOrders, int averageDistanceTraveled, int averageDeliveryTime, int averageOrderPrice, int workTime, int haveVehicle, DateTime workDay)
        {
            int index = Deliverers.FindIndex(x => x.DelivererNumber == delivererNumber &&  x.WorkDay == workDay);
            if (index == -1)
            {
                Deliverers.Add(new Deliverer() { DelivererNumber = delivererNumber, NumberOfSucsessOrders = numberOfSucsessOrders, NumberOfCancledOrders = namberOfCanceledOrders, AverageDistanceTraveled = averageDistanceTraveled, AverageDeliveryTime = averageDeliveryTime,AverageOrderPrice = averageOrderPrice, WorkTime = workTime, HaveVehicle = haveVehicle, WorkDay = workDay });
                File.WriteAllText(WorkPath, Serializer<Deliverer>(Deliverers));
            }
            else
            {
                EditDeliverer(index, delivererNumber, numberOfSucsessOrders, namberOfCanceledOrders, averageDistanceTraveled, averageDeliveryTime, averageOrderPrice, workTime, haveVehicle, workDay);
            }           
        }
        public static void IfDelivererExist(string delivererNumber, int numberOfSucsessOrders, int namberOfCanceledOrders, int averageDistanceTraveled, int averageDeliveryTime,int averageOrderPrice, int workTime, int haveVehicle, DateTime workDay)
        {
            int index = Deliverers.FindIndex(x => x.DelivererNumber == delivererNumber );
            if (index != -1)
            {
                EditDeliverer(index, delivererNumber, numberOfSucsessOrders, namberOfCanceledOrders, averageDistanceTraveled, averageDeliveryTime, averageOrderPrice, workTime, haveVehicle, workDay);
            }
        }
        public static void DeliteDeliverer(int deliverer)
        {
            Deliverers.RemoveAt(deliverer);
            File.WriteAllText(WorkPath, Serializer<Deliverer>(Deliverers));
        }
        public static void EditDeliverer(int index, string delivererNumber, int numberOfSucsessOrders, int namberOfCanceledOrders, int averageDistanceTraveled, int averageDeliveryTime,int averageOrderPrice, int workTime, int haveVehicle, DateTime workDay )
        {
            { 
                Deliverers[index].DelivererNumber = delivererNumber;
                Deliverers[index].NumberOfSucsessOrders = numberOfSucsessOrders;
                Deliverers[index].NumberOfCancledOrders = namberOfCanceledOrders;
                Deliverers[index].AverageDistanceTraveled = averageDistanceTraveled;
                Deliverers[index].AverageDeliveryTime = averageDeliveryTime;
                Deliverers[index].AverageOrderPrice = averageOrderPrice;
                Deliverers[index].WorkTime = workTime;
                Deliverers[index].HaveVehicle = haveVehicle;
                Deliverers[index].WorkDay = workDay;
            }
            File.WriteAllText(WorkPath, Serializer<Deliverer>(Deliverers));
        }

        public static void AddFile(string path)
        {
            WorkPath = path;
            File.Create(path).Close();
        }
        public static void OpenFile(string path)
        {
            WorkPath = path;
            Deliverers.AddRange(Deserializer(WorkPath));
            File.OpenWrite(path).Close();
        }
        public static string Serializer<T>(List<T> list)
        {
            return JsonSerializer.Serialize(list, options);
        }
        public static List<Deliverer> Deserializer (string path)
        {
            string jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Deliverer>>(jsonString);
        }
        static JsonSerializerOptions options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true
        };
    }
}

