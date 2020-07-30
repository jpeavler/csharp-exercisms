using System;

public class Robot
{
    private string robotName;
    private string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public Robot() {
        var random = new Random();
        string letter1 = ALPHABET[random.Next(26)].ToString();
        string letter2 = ALPHABET[random.Next(26)].ToString();
        string num1 = random.Next(10).ToString();
        string num2 = random.Next(10).ToString();
        string num3 = random.Next(10).ToString();
        robotName = "AE123";
    }
    public string Name
    {
        get
        {
            return robotName;
        }
    }

    public void Reset()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}