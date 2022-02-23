using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Text RoundScore;
    public Text TeamOneScore;
    public Text TeamTwoScore;

    void Start()
    {
        PopulateQuestion();
        PopulateAnswers();
    }

    private void PopulateQuestion()
    {
        foreach (Round round in RoomManager.Instance.CurrentRoom.rounds)
        {
            Debug.Log($"rounds ------------------------------------ { round.question}");
        }
    }
    
    private void PopulateAnswers()
    {
        
    }
}
