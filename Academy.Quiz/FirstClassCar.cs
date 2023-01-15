using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Academy.Quiz
{
    public class FirstClassCar : Car
    {

        //int status = 1;
        private bool Automatic { get; set; }
        private int Price { get; set; }


        public FirstClassCar(int status, bool Automatic, int Price, string color, string license_plate, int model_year, string model_name, int max_speed)
        {
            status = status;
            Automatic = Automatic;
            Price = Price;
            color = color;
            license_plate = license_plate;
            model_year = model_year;
            model_name = model_name;
            max_speed = max_speed;


        }
        
        public int ParkingFee(int time)
        {
            int Constant = 50;
            return time * Constant * 3;
        }


         public string carWashing()
         {
            return "Arabanız Yıkandı.";
         }
    }
}
