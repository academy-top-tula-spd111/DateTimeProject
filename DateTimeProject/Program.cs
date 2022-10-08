namespace DateTimeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2021, 5, 22);
            DateTime date2 = new DateTime(1998, 11, 6);
            DateTime date3 = new DateTime(2005, 3, 17);

            DateTime dateCurr = DateTime.Now;

            TimeSpan span = new TimeSpan(32, 16, 0, 0);

            Console.WriteLine(dateCurr.Add(span));
            Console.WriteLine(dateCurr.AddDays(-13));
            Console.WriteLine(dateCurr.AddYears(3));

            Console.WriteLine(dateCurr - date1);
            Console.WriteLine(dateCurr.Subtract(date1));

            Console.WriteLine(new String('*', 20));

            DateTime now = DateTime.Now;
            Console.WriteLine($"D: {now:D}");
            Console.WriteLine($"d: {now:d}");
            Console.WriteLine($"Y: {now:Y}");

            Console.WriteLine($"Y: {now:MMMM-yyyy+dd--hh:mm:ss}");
        }
    }
}