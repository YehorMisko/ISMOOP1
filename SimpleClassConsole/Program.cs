using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassConsole
{
    class Date
    {
        protected int Year;
        protected int Day;
        protected int Month;
        protected int Hours;
        protected int Minutes;
        protected int []month = new int[13];
        protected string [] CMonth = new string[13];
       public bool Verif()
        {
             
            int[] _Month = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] _Cmonth = { " ", "January", "February", "March", "April", "May", "June",
  "July", "August", "September", "October", "November", "December"};
            for (int i = 0; i <= 12; i++)
            {
                month[i] = _Month[i]; CMonth[i] = string.Copy(_Cmonth[i]);
            }
            if (Year < 0) return false;
            if (Month < 1 || Month > 12) return false;
            if (Year % 4 == 0 && Year % 100 != 0 || Year % 400 == 0)
                month[2] = 29;
            if (Day < 0 || Day > month[Month]) return false;
            return true;
        }
        bool Verifikation()
        {
            if (!Verif())
            {
                SetDay(1);
                SetMonth(1);
                SetYear(1900);
                return false;
            }
            else
                return true;
        }
        public Date()
    {
        Year = 1900;
        Day = 1;
        Month = 1;
        Hours = 0;
        Minutes = 0;
    }
    public Date(int year, int day, int month, int hours, int minutes)
    {
        Year = year;
            Day = day;
            Month = month;
            Hours = hours;
            Minutes = minutes;
            if (!Verifikation()) Console.WriteLine("Invalid Data!");
        }
        public Date(int year, int day, int month)
        {
            Year = year;
            Day = day;
            Month = month;
            Hours = 0;
            Minutes = 0;
            if (!Verifikation()) Console.WriteLine("Invalid Data!");
        }
        public Date(int year)
        {
            if (year < 0)
            Console.WriteLine("Invalid Data!");
            else
            Year = year;
            Day = 0;
            Month = 0;
            Hours = 0;
            Minutes = 0;
                 
        }
        public Date(int hours, int minutes)
        {
            if (hours < 0 || hours > 24 || minutes < 0 || minutes > 59)
                Console.WriteLine("Invalid Data!");
            else
            {
                Hours = hours;
                Minutes = minutes;
            }
        }
        public void SetDay(int day)
        {
            if (day < 0 || day > 31)
                Console.WriteLine("Invalid Data!");
            else
            Day = day;
     
        }
        public void SetYear(int year)
        {
            if (year < 0)
                Console.WriteLine("Invalid Data!");
            else
            Year = year;
            
        }
        public void SetMonth(int month)
        {
            if(month < 0 || month > 12)
                Console.WriteLine("Invalid Data!");
            else
            Month = month;

        }
        public void SetHours(int hours)
        {
           if(hours < 0 || hours > 24)
                Console.WriteLine("Invalid Data!");
           else
            Hours = hours;
        }
        public void SetMinutes(int minutes)
        {
            if(minutes < 0 || minutes > 59)
                Console.WriteLine("Invalid Data!");
            else
                Minutes = minutes;
        }
        public int GetMinutes()
        {
            return Minutes;
        }
        public int GetHours()
        {
            return Hours;
        }

        public int GetDay()
        {
            return Day;
        }

        public int GetYear()
        {
            return Year;
        }

        public int GetMonth()
        {
            return Month;
        }

    }
    class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;
        public Airplane()
        {
         StartCity = "None";
         FinishCity = "None";
         Date StartDate = new Date();
         Date FinishDate = new Date();
    }
        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            Date StartDate = new Date();
            Date FinishDate = new Date();
        }
        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishDate = airplane.FinishDate;
            FinishCity = airplane.FinishCity;
            StartDate = airplane.StartDate;
        }
        public void SetStartCity(string startCity)
        {
            StartCity = startCity;
        }
        public void SetStartDate(Date startDate)
        {
            StartDate = startDate;
        }
        public void SetFinishCity(string finishCity)
        {
           FinishCity = finishCity;
        }
        public void SetFinishDate(Date finishDate)
        {
            FinishDate = finishDate;
        }
        public string SetStartCity()
        {
            return StartCity;
        }
        public Date GetStartDate()
        {
            return StartDate;
        }
        public string GetFinishCity()
        {
            return FinishCity;
        }
        public Date GetFinishDate()
        {
            return FinishDate;
        }
        public int GetTotalTime()
        {
            Date startTemp = new Date(StartDate.GetHours(), StartDate.GetMinutes());
            Date finishTemp = new Date(FinishDate.GetHours(), FinishDate.GetMinutes());
            int start = (startTemp.GetHours() * 60) + startTemp.GetMinutes();
            int finish = (finishTemp.GetHours() * 60) + finishTemp.GetMinutes();
            return finish - start;
        }
        public bool IsArrivingToday()
        {
            if (StartDate.GetDay() == FinishDate.GetDay()
                && StartDate.GetMonth() == FinishDate.GetMonth()
                && StartDate.GetYear() == FinishDate.GetYear())
                return true;
            else
                return false;
        }
    }
    class Product
    {
        protected string Name;
        protected int Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected int Weight;
        public Product()
        {
            Name = "-";
            Price = 0;
            Currency Cost = new Currency();
            Quantity = 0;
            Producer = "-";
            Weight = 0;
        }
        public Product(string name, int price, Currency cost, int quantity, string producer, int weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(Product temp)
        {
            Name = temp.Name;
            Price = temp.Price;
            Cost = temp.Cost;
            Quantity = temp.Quantity;
            Producer = temp.Producer;
            Weight = temp.Weight;
        }
        public Product(string name, int price, int quantity, int weight)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Weight = weight;
            Currency Cost = new Currency();
            Producer = "-";
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetPrice(int price)
        {
            if (price < 0)
                Console.WriteLine("Invalid Data!");
            else
                Price = price;
        }
        public void SetCost(Currency cost)
        {
            Cost = cost;
        }
        public void SetQuantity(int quantity)
        {
            if (quantity < 0)
                Console.WriteLine("Invalid Data!");
            else
            Quantity = quantity;
        }
        public void SetProducer(string producer)
        {
            Producer = producer;
        }
        public void SetWeight(int weight)
        {
            if (weight < 0)
                Console.WriteLine("Invalid Data!");
            else
            Weight = weight;
        }
        public int GetWeight()
        {
            return Weight;
        }
        public int GetPrice()
        {
            return Price;
        }
        public Currency GetCost()
        {
            return Cost;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetProducer()
        {
            return Producer;
        }
        public int GetQuantity()
        {
            return Quantity;
        }
        public double GetPriceinUAH()
        {
            return Price * Cost.GetExRate();
        }
        public double GetTotalPriceInUAH()
        {
            return Price * Quantity * Cost.GetExRate();
        }
        public double GetTotalWeight()
        {
            return Quantity * Weight;
        }
    }
    class Currency
    {
        protected string Name;
        protected double ExRate;
        
        public Currency()
        {
            Name = "-";
            ExRate = 0;
        }
        public Currency(Currency temp)
        {
            Name = temp.Name;
            ExRate = temp.ExRate;
        }
        public Currency(string name)
        {
            Name = name;
            ExRate = 0;
        }
        public Currency(string name, int exRate)
        {
            Name = name;
            ExRate = exRate;
        }
        public string GetName()
        {
            return Name;
        }
        public double GetExRate()
        {
            return ExRate;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetExRate(double exRate)
        {
            if (exRate < 0)
                Console.WriteLine("Invalid Data!");
            else
                ExRate = exRate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
