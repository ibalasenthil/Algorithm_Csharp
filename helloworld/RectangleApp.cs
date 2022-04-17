using System;
namespace Rec
{
    class Rclass
    {
        //member variables
        double lenght;
        double width;
        public void AcceptDetails()
        {
            lenght = 4.5;
            width = 3.5;            
        }
        public int GetArea()
        {
            //return lenght*width;
            return Convert.ToInt32(lenght)*Convert.ToInt32(width);
        }  
        public void display ()
        {
            Console.WriteLine("Length is:"+ lenght);
            System.Console.WriteLine("Width is:"+ width);
            System.Console.WriteLine("Area is:"+ GetArea());
        } 
    }
    class ExecuteRec
    {
        static void Main(string[] args)
        {
            Rclass r = new Rclass();
            r.AcceptDetails();
            r.display();
            Console.ReadLine();
        }
    }
}