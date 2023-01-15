using Academy.Quiz;
namespace Academy.Quiz
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<ICar> CarsInPark = new List<ICar>();

            FirstClassCar car = new FirstClassCar(1,true,100000,"Black","34AB8966",2020, "ModelAdıBilmiyorum", 500);
            SecondClassCar car2 = new SecondClassCar(2,500,true,"blue","34GH6542",2005,"ModelAdıBilmiyorum2",170);
            Car car3 = new Car(3,"red","34OP8942",2020,"ModelAdıBilmiyorum3",150);
            CarsInPark.Add(car);    
            CarsInPark.Add(car2);
            CarsInPark.Add(car3);

            ListCars(CarsInPark);

            PowerCalculate(car.power);

            ListCar(CarsInPark, 2);

            car.ParkingFee(300);
            car2.ParkingFee(300);

            car3.ParkingFee(300);

            
            Console.WriteLine(car.carWashing);

            Console.WriteLine(car2.ChangeWheel);


        }

        public static void ListCars(List<ICar> CarsInPark)
        {
            foreach (var item in CarsInPark)
            {
                Console.WriteLine(item);
            }
        }

        public static int PowerCalculate(int power)
        {
            return power * 3;
        }

        

        public static void ListCar(List<ICar> CarsInPark,int status)
        {

            foreach (ICar item in CarsInPark)
            {
                for (int i = 0; i < CarsInPark.Count(); i++)
                {
                    if (item.status == CarsInPark[i].status)
                    {
                        Console.WriteLine(item);

                    }

                }          
                
                
            }
        }


    }
}
