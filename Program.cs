
// sten sax påse, individuell uppgift.
string[] listWords = File.ReadAllLines("../../../BennyAhlin.txt");
int totalScore = 0;
int count = 0;
int count2 = 0;
for (int i = 0; i < listWords.Length - 25; i++)
{
    count++;
    Array.Sort(listWords);

    string letter = listWords[i];
    string letter1 = listWords[i + 1];
    string letter5 = listWords[i + 5];
    string letter25 = listWords[i + 25];

    if (letter == letter25 && letter == "A X")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 3 * 25;
        i += 25;
    }
    else if (letter == letter5 && letter == "A X")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 3 * 5;
        i += 5;

    }
    else if (letter == letter1 && letter == "A X")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 3;
        i += 1;

    }
    else if (letter != letter1 && letter == "A X")
    {
        totalScore += 3;
        i += 1;


    }
    if (letter == letter25 && letter == "A Y")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 4 * 25;
        i += 25;
    }
    else if (letter == letter5 && letter == "A Y")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 4 * 5;
        i += 5;
    }
    else if (letter == letter1 && letter == "A Y")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 4;
        i += 1;
    }
    else if (letter != letter1 && letter == "A Y")
    {
        totalScore += 4;
        i += 1;
    }

    if (letter == letter25 && letter == "A Z")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 8 * 25;
        i += 25;
    }
    else if (letter == letter5 && letter == "A Z")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 8 * 5;
        i += 5;
    }
    else if (letter == letter1 && letter == "A Z")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 8;
        i += 1;
    }
    else if (letter != letter1 && letter == "A Z")
    {
        totalScore += 8;
        i += 1;
    }


    if (letter == letter25 && letter == "B X")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += (1 * 25);
        i += 25;
    }
    else if (letter == letter5 && letter == "B X")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += (1 * 5);
        i += 5;
    }
    else if (letter == letter1 && letter == "B X")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 1;
        i += 1;
    }
    else if (letter != letter1 && letter == "B X")
    {
        totalScore += 1;
        i += 1;
    }
    if (letter == letter25 && letter == "B Y")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 5 * 25;
        i += 25;
    }
    else if (letter == letter5 && letter == "B Y")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 5 * 5;
        i += 5;
    }
    else if (letter == letter1 && letter == "B Y")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 5;
        i += 1;
    }
    else if (letter != letter1 && letter == "B Y")
    {
        totalScore += 5;
        i += 1;
    }

    if (letter == letter25 && letter == "B Z")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 9 * 25;
        i += 25;
    }
    else if (letter == letter5 && letter == "B Z")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 9 * 5;
        i += 5;
    }
    else if (letter == letter1 && letter == "B Z")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 9;
        i += 1;
    }
    else if (letter != letter1 && letter == "B Z")
    {
        totalScore += 9;
        i += 1;
    }

    if (letter == letter25 && letter == "C X")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 2 * 25;
        i += 25;
    }
    else if (letter == letter5 && letter == "C X")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 2 * 5;
        i += 5;
    }
    else if (letter == letter1 && letter == "C X")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 2;
        i += 1;
    }
    else if (letter != letter1 && letter == "C X")
    {
        totalScore += 2;
        i += 1;
    }
    if (letter == letter25 && letter == "C Y")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += (6 * 25);
        i += 25;
    }
    else if (letter == letter5 && letter == "C Y")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += (6 * 5);
        i += 5;
    }
    else if (letter == letter1 && letter == "C Y")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 6;
        i += 1;
    }
    else if (letter != letter1 && letter == "C Y")
    {
        totalScore += 6;
        i += 1;
    }

    if (letter == letter25 && letter == "C Z")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += (7 * 25);
        i += 25;
        // 10 gånger
    }
    else if (letter == letter5 && letter == "C Z")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += (7 * 5);
        i += 5;
        // 1 gånger

    }
    else if (letter == letter1 && letter == "C Z")         // AX AY AZ   BX BY BZ      CX CY CZ
    {
        totalScore += 7;
        i += 1;

        //2 gånger
    }
    else if (letter != letter1 && letter == "C Z")
    {
        totalScore += 6;
        i += 1;
    }
    //169 GÅNGER
    count2++;

}
Console.WriteLine("total score: " + totalScore + ". You should have: 12426");
Console.WriteLine("Total count: " + count);
Console.WriteLine("Total count2: " + count2);