class Prompt
{

    private List<string> _prompts = new List<string>
    {
        "What’s something ridiculously small that made me happy today?",

        "If my life were a sitcom, what would today’s episode be called?",

        "What’s my current “main character” moment?",

        "What song would play during the highlight reel of my day?",

        "What’s the funniest thing that happened this week (even if it shouldn’t have been funny)?"
    };
    private string _prompt;
    private static Random _randomGenerator = new Random();

    public string GetRandomPrompt()
    {
        int randomIndex = _randomGenerator.Next(_prompts.Count);
        _prompt = _prompts[randomIndex];
        return _prompt;
    }
}