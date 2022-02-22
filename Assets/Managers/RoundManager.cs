using UnityEngine;

public class RoundManager
{
    private static RoundManager _instance;
    public Round CurrentRound { get; private set; }

    public static RoundManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new RoundManager();
            }
            return _instance;
        }
    }

    private RoundManager() { }

    public void SetRound()
    {
        Round round = new Round
        {
            Name = CurrentRound.Name++
        };
        CurrentRound = round;
    }

    public void SetScore()
    {
        var score = PlayerPrefs.GetInt("score");
        CurrentRound.Score = score;
    }
}
