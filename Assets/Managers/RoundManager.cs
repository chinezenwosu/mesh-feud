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

    public void SetRound(Round round)
    {
        CurrentRound = round;
    }

    public void AddToRoundScore(int score)
    {
        CurrentRound.Score += score;
    }

    public void AddToTeamScore(Team team, int score)
    {
        CurrentRound.Score += score;
    }
}
