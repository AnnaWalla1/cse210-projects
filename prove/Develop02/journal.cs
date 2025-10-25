class Journal
{
    private List<Entry> _entries = new List<Entry>();
    public List<Entry> AddEntry(Entry entry)
    {
        _entries.Add(entry);
        return _entries;
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }
    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }
    }
    public void ReadFromFIle(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("#");
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry entry = new Entry(date, prompt, response);
            AddEntry(entry);
        }
    }
}