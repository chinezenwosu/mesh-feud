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

    public void RevealAnswer(Answer answer)
    {
        answer.Revealed = true;
    }

    public void AddToRoundScore(int score)
    {
        CurrentRound.Score += score;
    }

    public void ResetRoundScore()
    {
        CurrentRound.Score = 0;
    }

    public void SelectStartingTeam(Team team)
    {
        CurrentRound.Starter = team;
    }

    public void IncrementMistakeCount()
    {
        if (CurrentRound.Starter.Mistakes < 3)
        {
            CurrentRound.Starter.Mistakes++;
        }
    }
}
