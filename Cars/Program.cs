using System;

namespace Cars
{
    class CarEventHandler
    {
        public int AmountCar { get; set; }
        public string Message { get; set; }
        public CarEventHandler(string mess, int count)
        {
            AmountCar = count;
            Message = mess;
        }
    }
    class Service
    {
        public delegate void CarsHandler(object sender, CarEventHandler e);
        public event CarsHandler Notify;
        public int AmountCars { get; set; }
        private CarsHandler cars;
        public Service()
        {
            AmountCars = 10;
        }

        public void AddCar(int count)
        {
            if (count <= 10)
            {
                AmountCars += count;
                Notify?.Invoke(this, new CarEventHandler($"Added car count", count));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            service.Notify += ShowMessage;
            service.AddCar(1);
        }
        private static void ShowMessage(object sender,CarEventHandler e)
        {
            Console.WriteLine($"Count cars {e.AmountCar}");
            Console.WriteLine(e.Message);
        }
    }
}
