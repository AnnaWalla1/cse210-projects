class Scripture
{

    private List<string> _scriptures = new List<string>
    {
        //John11;35
        "Jesus Wept",
//1st Nephi 17:51
        "And now, if the Lord has such great power, and has wrought so many miracles among the children of men, how is it that he cannot instruct me, that I should build a ship?",
//alma 5:33
        " Behold, he sendeth an invitation unto all men, for the arms of mercy are extended towards them, and he saith: Repent, and I will receive you.",
//DyC 6;36
        "Look unto me in every thought; doubt not, fear not.",
// Acts 2:3-4
        " And there appeared unto them cloven tongues like as of fire, and it sat upon each of them.                                                                    And they were all filled with the Holy Ghost, and began to speak with other tongues, as the Spirit gave them utterance."
    };
    private string _scripture;
    private static Random _randomGenerator = new Random();

    public string GetRandomPrompt()
    {
        int randomIndex = _randomGenerator.Next(_scriptures.Count);
        _scripture = _scriptures[randomIndex];
        return _scripture;
    }
}



// using System.Security.Cryptography.X509Certificates;

// class Scripture
// {
//     private string _givenScripture;
//     private string _givenWord;
//     // private string _entryText;

//     //behavior
//     public Scripture()
//     {
//         _givenScripture = " ";
//         _givenWord = " ";
//         _givenScripture = " ";
//         public Scripture(string scripture, string word,)
//     {
//         _givenScripture = scripture;
//         _givenWord = word;
//     }
//          public override string ToString()
//     {
//         return $"{_givenScripture}#{_givenWord}#";

//     }
        
//     }
// }


