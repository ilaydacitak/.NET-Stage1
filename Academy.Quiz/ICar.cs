using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Quiz
{
     interface ICar
    {
        int PowerCalculate(int power,int max_speed);

        public int ParkingFee(int time);

        int status { get; set; }

        string color { get; set; }

        string license_plate { get; set; }

        int model_year { get; set; }

        string model_name { get; set; }

        int max_speed { get; set; }



    }
}
