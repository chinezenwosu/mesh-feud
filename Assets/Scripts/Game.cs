using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    private Round round;
    public TMP_Text RoundScore;
    public TMP_Text TeamOneScore;
    public TMP_Text TeamTwoScore;
    public TMP_Text Question;
    public TMP_Text RoomId;
    public Image AnswerContainer;
    public GameObject AnswersPanel;
    public Button NextQuestionButton;
    public Button AwardTeamOneButton;
    public Button AwardTeamTwoButton;

    void Start()
    {
        round = RoundManager.Instance.CurrentRound;
        PopulateRoomId();
        PopulateQuestion();
        PopulateAnswers();
    }

    private void PopulateRoomId()
    {
        RoomId.text = $"ROOM {RoomManager.Instance.CurrentRoom.Id}";
    }

    private void PopulateQuestion()
    {
        Question.text = round.Question;
    }
    
    private void PopulateAnswers()
    {
        List<Answer> answers = round.Answers;
        foreach (Answer answer in answers)
        {
            Image answerItem = Instantiate(AnswerContainer);
            GridLayoutGroup layoutGroup = AnswersPanel.GetComponent<GridLayoutGroup>();
            TMP_Text answerText = answerItem.transform.Find("AnswerBackPlate")?.GetComponentInChildren<TMP_Text>();
            TMP_Text pointsText = answerItem.transform.Find("PointsBackPlate")?.GetComponentInChildren<TMP_Text>();

            answerText.text = answer.Text;
            pointsText.text = answer.Points.ToString();
            answerItem.transform.SetParent(layoutGroup.transform, false);
        }

        Destroy(AnswerContainer.gameObject);
    }

    public void AwardTeam(int team)
    {

    }
}
