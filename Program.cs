namespace Datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            // Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            // Console.WriteLine(myValue.ToShortTimeString());
            // Console.WriteLine(myValue.ToLongDateString());
            //  Console.WriteLine(myValue.ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(4).ToLongDateString());
            //  Console.WriteLine(myValue.AddHours(3).ToLongTimeString());  
            //  Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            //Console.WriteLine(myValue.Month);

            //DateTime myBirthday = new DateTime(1999, 11,  29);
            //  Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthDay = DateTime.Parse("11/29/1999");
           TimeSpan myage = DateTime.Now.Subtract(myBirthDay);

            Console.WriteLine(myage.TotalDays);
            Console.ReadLine();
        }
    }
}



