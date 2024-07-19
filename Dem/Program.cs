using System;
using System.Text;

namespace Dem
{
    internal class Program
    {

        public static void Print10Num(ISeries series)
        {
            if (series != null) 
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{series.Current}");
                    series.GetNext();


                }

            series.Reset();
            
            
            }  
        
        
        }


        static void Main(string[] args)
        {
            #region EX1

            //SeriesTwo seriesTwo = new SeriesTwo();

            //Print10Num(seriesTwo);


            //SeriesThree seriesThree = new SeriesThree();
            //Print10Num(seriesThree);

            //SeriesFour seriesFour = new SeriesFour();
            //Print10Num(seriesFour); 
            #endregion

            #region EX2
            //Car car = new Car();
            //car.Backward();
            //car.Forward();

            //AirPlane airplane = new AirPlane();
            //airplane.Backward();
            //IMovable movable = new AirPlane();
            //movable.Backward();
            //IFlyable movable2 = new AirPlane();
            //movable2.Backward(); 
            #endregion

            #region EX3
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3];


            //Console.WriteLine(  $"HC{Arr01.GetHashCode()}");

            //Console.WriteLine($"HC{Arr02.GetHashCode()}");

            //Arr02 = Arr01;


            //Console.WriteLine($"HC{Arr01.GetHashCode()}");

            //Console.WriteLine($"HC{Arr02.GetHashCode()}");


            //Console.WriteLine($"HC{Arr01[0]}");

            //Console.WriteLine($"HC{Arr02[0]}");
            //Arr02[0]= 100;

            //Console.WriteLine($"HC{Arr01.GetHashCode()}");

            //Console.WriteLine($"HC{Arr02.GetHashCode()}");




            #endregion

            #region Deep copy

            //Arr02=(int[])Arr01.Clone();

            //Console.WriteLine($"HC{Arr01.GetHashCode()}");

            //Console.WriteLine($"HC{Arr02.GetHashCode()}");


            //Console.WriteLine($"HC{Arr01[0]}");

            //Console.WriteLine($"HC{Arr02[0]}");

            #endregion

            #region Array  of Ref Type

            #region Array string
            //string[] name0 = { "omar" };
            //string[] name1 = new string[1];

            //Console.WriteLine($"{name0.GetHashCode()}");
            //Console.WriteLine($"{name1.GetHashCode()}");

            //name1 = name0;
            //Console.WriteLine($"{name0.GetHashCode()}");
            //Console.WriteLine($"{name1.GetHashCode()}");

            //Console.WriteLine($"{name0[0]}");
            //Console.WriteLine($"{name1[0]}");

            //name1[0] = "aya";
            //Console.WriteLine($"{name0[0]}");
            //Console.WriteLine($"{name1[0]}");


            #endregion

            #region array of string builder
            //StringBuilder[]  name0 = new StringBuilder[1] ;
            //name0[0].Append("omar");
            //StringBuilder[] name1 = new StringBuilder[1];

            //Console.WriteLine($"{name0[0]}");
            //Console.WriteLine($"{name1[0]}");
            //name1=name0 ;
            //Console.WriteLine($"{name0.GetHashCode()}");
            //Console.WriteLine($"{name1.GetHashCode()}");
            //name1[0].Append("ali");
            //Console.WriteLine($"{name0[0]}");
            //Console.WriteLine($"{name1[0]}");







            #endregion





            #endregion


            #region Build in  

            //int[] number = { 1, 2, 3,5,89,8,7,2,48,5 };
            //Array.Sort(number);
            //foreach (int i in number)
            //{
            //    Console.WriteLine(i);
            //}





            

            #endregion



        }

    }



}