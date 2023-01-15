using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Quiz
{
    public class Car : ICar
    {
         
        string ICar.color { get; set; }
        string ICar.license_plate { get; set; }
        int ICar.model_year { get; set; }
        string ICar.model_name { get; set; }
        int ICar.max_speed { get; set; }
        int ICar.status { get; set; }

         int ICar.ParkingFee(int time)
        {
            int Constant = 50;
            return time * Constant;
        }

        int ICar.PowerCalculate(int power, int max_speed)
        {
            return power * max_speed;
        }

        public Car(int status, string color, string license_plate, int model_year, string model_name, int max_speed) 
        {
            status = status;
            color = color;
            license_plate = license_plate;
            model_year = model_year;
            model_name = model_name;
            max_speed = max_speed;



        }
    }
}
