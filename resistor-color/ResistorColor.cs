using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int index = 10;
        string[] colorArray = Colors();
        for(int i = 0; i < colorArray.Length; i++) {
            if(colorArray[i] == color){index = i;}
        }
        return index;
    }

    public static string[] Colors()
    {
        return new [] {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
    }
}