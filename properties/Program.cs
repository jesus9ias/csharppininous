using System;

namespace properties
{
    class times
    {
        public float seconds;
        public float minutes
        {
            get { return seconds / 60; }
            set { seconds = value * 60; }
        }
        public float hours
        {
            get { return minutes / 60; }
            set { minutes = value * 60; }
        }
        public float days
        {
            get { return hours / 24; }
            set { hours = value * 24; }
        }
        public float years
        {
            get { return days / 365; }
            set { days = value * 365; }
        }

        public times(float years)
        {
            this.years = years;
        }

        public string getInfo()
        {
            return years + " years are: " + days + " days, " + hours + " hours, " + minutes + " minutes and " + seconds + " seconds";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Write a year number");
            string years = Console.ReadLine();
            times calcTime = new times(float.Parse(years));
            Console.Write(calcTime.getInfo());

            Console.ReadLine();

        }
    }
}
