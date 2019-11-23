namespace MVC_Homework.Models
{
    using System;

    public class ThreeNumbers
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int RandomNumber
        {
            get
            {
                Random r = new Random();
                return r.Next(FirstNumber, SecondNumber);
            }
        }
    }
}