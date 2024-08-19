namespace Section02
{
    internal class BT02
    {
        private static void Main01(string[] args)
        {
            var name = "quinchem";
            var date = DateTime.Now;
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, " + $"it's {date:HH:mm} now.");
        }
    }
}
