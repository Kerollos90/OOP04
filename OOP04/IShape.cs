using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    public interface IShape
    {
        public double Area { get;  }
        void DisplayAreaInfo();
    }

    public interface ICircle : IShape
    {
       public  double Radius { get => Math.PI * Radius * Radius; }



    }

    public interface IRectangle : IShape
    {
        public double Height { get; set; }  
        public double Width { get; set; }

    }


    public class Circle() : ICircle
    {
      

        public double Area { get => Math.PI * Radius * Radius; }

        public double Radius { get; set; }

     

        public void DisplayAreaInfo()
        {
            Console.WriteLine($" Circle:: Radius = {Radius} :: Area = { Area}");
        }
    }

    public class  Rectangle () : IRectangle
    {
        public double Area { get => Width * Height; }
        public double Height { get; set ; }
        public double Width { get ; set ; }

        public void DisplayAreaInfo()
        {
            Console.WriteLine($"  Rectangle :: Width = {Width} , Height = {Height} :: Area = {Area} "); 
        }
    }

   
            


}
