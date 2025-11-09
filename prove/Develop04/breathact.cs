class BreathActivity : Activities
{
    public BreathActivity()
        : base(
            "Welcome to the Breathing Activity!",
            "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.")
    { }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4);

            Console.Write("Breathe out... ");
            ShowCountdown(4);
        }

        DisplayEndingMessage();
    }
}
