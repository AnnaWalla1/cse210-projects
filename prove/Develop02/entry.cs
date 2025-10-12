using Microsoft.VisualBasic;

class Entry
{
    //attrivutes
    public string _givenPrompt;
    public string _entryDate;
    public string -entryText;

    //behavior

    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();
    
}