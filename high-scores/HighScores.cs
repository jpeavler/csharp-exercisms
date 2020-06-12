using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> highScoresList;

    public HighScores(List<int> list)
    {
        highScoresList = list;
    }

    public List<int> Scores()
    {
        return highScoresList;
    }

    public int Latest()
    {
        throw new NotImplementedException();
    }

    public int PersonalBest()
    {
        int highScore = 0;
        foreach(int score in highScoresList) {
            if(highScore < score) {highScore = score;}
        }
        return highScore;
    }

    public List<int> PersonalTopThree()
    {
        throw new NotImplementedException();
    }
}