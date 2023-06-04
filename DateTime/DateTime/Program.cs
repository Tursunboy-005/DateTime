namespace DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.DateTime date = new System.DateTime();
            System.DateTime date1 = new System.DateTime(2005,12,11);
            System.DateTime date2 = new System.DateTime(2023,06,02);
            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date);


            // static properties 

            Console.WriteLine($"Min {System.DateTime.MinValue}");
            Console.WriteLine($"Max {System.DateTime.MaxValue}");
            Console.WriteLine($"UTC now {System.DateTime.UtcNow}");
            Console.WriteLine($"Now {System.DateTime.Now}");
            Console.WriteLine($"Today {System.DateTime.Today}");

            // Parsing string to date 

            string datetime = "today";
            string correctDate = "2021/12/31 12:10:00";

            if(System.DateTime.TryParse(datetime, out date))
                Console.WriteLine(date);
            else
                Console.WriteLine("Incorrect Date time");


            // object properties

            Console.WriteLine($"Date{date.Date}");
            Console.WriteLine($"Date{date.Year}");
            Console.WriteLine($"Date{date.Month}");
            Console.WriteLine($"Date{date.Day}");
            Console.WriteLine($"Date{date.Hour}");
            Console.WriteLine($"Date{date.Minute}");
            Console.WriteLine($"Date{date.Second}");
            Console.WriteLine($"Year {date.Millisecond}");

            Console.WriteLine();
            Console.WriteLine(date);

            Console.WriteLine($"Add 100 millisecond: {date.AddMilliseconds}");
            Console.WriteLine($"Add 10 second: {date.AddSeconds}");
            Console.WriteLine($"Add 1 minutes: {date.AddMinutes}");
            Console.WriteLine($"Add 1 hour: {date.AddHours}");
            Console.WriteLine($"Add 1 day: {date.AddDays}");


            CompareTime(date1, date2);
            Different(date1, date2);
            
            
        }
        public static void CompareTime(System.DateTime date1, System.DateTime date2)
        {
            Console.WriteLine(date1.CompareTo(date2));
        }
        public static void Different(System.DateTime date1, System.DateTime date2)
        {
            Console.WriteLine(date1.Subtract(date2));
        }

 
    }
}