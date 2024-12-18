
class Program
{
    static void Main(string[] args)
    {
       
        var activities = new List<Activity>
        {
            new Running("04 dec 2024", 30, 3.0),
            new Cycling("05 dec 2024", 30, 15.0),
            new Swimming("06 dec 2024", 30, 20)
        };

        
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
