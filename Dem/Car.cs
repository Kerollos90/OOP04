using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dem
{


    public interface IMovable
    {

        void Forward();
        void Backward();
        void Right();
        void Left();
        
        
        
        
        
        
    }

    public interface IFlyable
    {

        void Forward();
        void Backward();
        void Right();
        void Left();






    }



    public class Vehicle
    {

        public int Speed { get; set; }


    }



    internal class Car : Vehicle, IMovable
    {
        public void Backward()
        {
            Console.WriteLine("Car Move Backward on Ground");
        }

        public void Forward()
        {
           
        }

        public void Left()
        {
           
        }

        public void Right()
        {
            
        }
    }




    public class AirPlane : Vehicle, IMovable, IFlyable
    {
        public void Backward()
        {
            Console.WriteLine("AirPlane Move Backward");
        }

        void IFlyable.Backward()
        {
            throw new NotImplementedException();
        }

        void IMovable.Forward()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Forward()
        {
            throw new NotImplementedException();
        }

        void IMovable.Left()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }

        void IMovable.Right()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }
    }










}
