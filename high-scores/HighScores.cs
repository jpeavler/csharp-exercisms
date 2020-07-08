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
        return highScoresList[highScoresList.Count -1];
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
        List<int> topThree = highScoresList.OrderByDescending(x => x).ToList();
        if(topThree.Count > 3) {
        topThree.RemoveRange(3, topThree.Count() -3);
        }
        return topThree;
    }
}