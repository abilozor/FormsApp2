using System;

namespace lab_work_4
{
    public class Car
    {
        public string ModelName { get; set; }
        public string Manufacturer { get; set; }
        public int YearOfProduction { get; set; }
        public double EngineCapacity { get; set; }
        public int SeatCount { get; set; }
        public bool IsElectric { get; set; }
        public double AverageFuelConsumption { get; set; }

        public Car()
        { }

        public Car(string modelName, string manufacturer, int yearOfProduction, 
            double engineCapacity, int seatCount, bool isElectric, double averageFuelConsumption)
        {
            ModelName = modelName;
            Manufacturer = manufacturer;
            YearOfProduction = yearOfProduction;
            EngineCapacity = engineCapacity;
            SeatCount = seatCount;
            IsElectric = isElectric;
            AverageFuelConsumption = averageFuelConsumption;
        }

        public double GetFuelConsumptionPer100Km()
        {
            return AverageFuelConsumption;
        }

        public int GetCarAge()
        {
            return DateTime.Now.Year - YearOfProduction;
        }
    }
}
