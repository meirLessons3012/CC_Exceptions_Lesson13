using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Exceptions_Lesson13
{
    public class Car
    {
        public int Doors { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public Car(int doors, string color, int year)
        {
            SetDoors(doors);
            SetYear(year);
            SetColor(color);
        }

        public void SetDoors(int doors)
        {
            if (doors < 1)
            {
                ArgumentDoorsException argExc = new ArgumentDoorsException("doors cannot be 0");
                throw argExc;
            }
            Doors = doors;
        }

        public void SetColor(string color)
        {
            if (string.IsNullOrEmpty(color))
            {
                ArgumentColorException argExc = new ArgumentColorException("color cannot be null or empty");
                throw argExc;
            }
            Color = color;
        }

        public void SetYear(int year)
        {
            if (year < 1930)
            {
                ArgumentException argExc = new ArgumentException("year must be greather than 1930");
                throw argExc;
            }
            Year = year;
        }
    }
}
