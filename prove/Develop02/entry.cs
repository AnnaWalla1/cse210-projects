using Microsoft.VisualBasic;

class Entry
{
    //attrivutes
    private string _givenPrompt;
    private string _entryDate;
    private string _entryText;

    //behavior
    public Entry()
    {
        _givenPrompt = " ";
        _entryDate = " ";
        _entryText = " ";
    }
    public Entry(string prompt, string date, string text)
    {
        _givenPrompt = prompt;
        _entryDate = date;
        _entryText = text;
    }

    public string getDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _entryDate = theCurrentTime.ToShortDateString();
        return _entryDate;
    }

    public override string ToString()
    {
        return $"{_entryDate}#{_givenPrompt}#{_entryText}";

    }
    public string GetResponse()
    {
        Prompt _promptGenerator = new Prompt();
        _givenPrompt = _promptGenerator.GetRandomPrompt();
        Console.Write(_givenPrompt);
        _entryText = Console.ReadLine();
        return _entryText;

    }
}