class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Run(new DateTime(2022,11,3), 30, 3.0),
            new Bike(new DateTime(2022,11,3), 45, 15.0),
            new Swim(new DateTime(2022,11,3), 30, 40)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
