using System;

public class Robot {
    private string generateName () {
        var random = new Random();
        string letter1 = ALPHABET[random.Next(26)].ToString();
        string letter2 = ALPHABET[random.Next(26)].ToString();
        string num1 = random.Next(10).ToString();
        string num2 = random.Next(10).ToString();
        string num3 = random.Next(10).ToString();
        return string.Concat(letter1, letter2, num1, num2, num3);
    }
    private string robotName;
    private string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public Robot() {
        robotName = generateName();
    }
    public string Name {
        get { return robotName; }
    }

    public void Reset() {
        robotName = generateName();
    }
}