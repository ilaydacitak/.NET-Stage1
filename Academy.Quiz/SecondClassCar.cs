using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Quiz
{
    public class SecondClassCar : Car
    {
        private int Luggage { get; set; }

        private bool SpareWheel { get; set; }


        public SecondClassCar(int status, int Luggage, bool SpareWheel, string color, string lisanca_plate, int model_year, string model_name, int max_speed)
        {
            status = 2;
            Luggage = Luggage;
            SpareWheel = false;
            color = color;
            lisanca_plate = lisanca_plate;
            model_year = model_year;
            model_name = model_name;
            max_speed = max_speed;

        }

        
        public int ParkingFee(int time)
        {
            int Constant = 50;
            return time * Constant * 2;
        }


        public void ChangeWheel()
        {
            Console.WriteLine("Lastik Değiştirildi");
        }
    }
}
