using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    private Round round;
    private int maxMistakeCount = 3;
    public TMP_Text RoundScore;
    public TMP_Text TeamOneScore;
    public TMP_Text TeamTwoScore;
    public TMP_Text Question;
    public TMP_Text RoomId;
    public GameObject AnswersPanel;
    public Button AnswerButton;
    public Button NextQuestionButton;
    public Button TeamOneAwardButton;
    public Button TeamTwoAwardButton;
    public Button MistakeButton;

    void Start()
    {
        round = RoundManager.Instance.CurrentRound;
        round.Teams = TeamManager.Instance.CurrentTeams;

        PopulateRoomId();
        PopulateQuestion();
        PopulateAnswers();
        PopulatePoints();

        //implement buzzer later. For now set Team 1 as starter
        SetStarter(round.Teams[0]);
    }

    private void SetStarter(Team team)
    {
        RoundManager.Instance.SelectStartingTeam(team);
        MistakeButton.GetComponentInChildren<TMP_Text>().text = $"{team.Name} Made a Mistake";
        MistakeButton.onClick.AddListener(() => SetMistakeCount(team));
    }

    private void SetMistakeCount(Team team)
    {
        RoundManager.Instance.IncrementMistakeCount();
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
        int currentIndex = 0;
        foreach (Answer answer in answers)
        {
            currentIndex++;
            Button answerItem = Instantiate(AnswerButton);
            GridLayoutGroup layoutGroup = AnswersPanel.GetComponent<GridLayoutGroup>();
            TMP_Text answerText = answerItem.transform.Find("AnswerBackPlate").GetComponentInChildren<TMP_Text>();
            TMP_Text pointsText = answerItem.transform.Find("PointsBackPlate").GetComponentInChildren<TMP_Text>();
            Transform serialNumberPanel = answerItem.transform.Find("RevealPanel");
            TMP_Text serialNumberText = serialNumberPanel.GetComponentInChildren<TMP_Text>();

            answerText.text = answer.Text;
            pointsText.text = answer.Points.ToString();
            serialNumberText.text = currentIndex.ToString();
            answerItem.transform.SetParent(layoutGroup.transform, false);
            answerItem.onClick.AddListener(() => OnRevealAnswer(answer, serialNumberPanel));
        }

        Destroy(AnswerButton.gameObject);
    }

    private void PopulatePoints()
    {
        RoundScore.text = round.Score.ToString();
    }

    private void OnRevealAnswer(Answer answer, Transform serialNumberPanel)
    {
        if (!answer.Revealed)
        {
            RoundManager.Instance.RevealAnswer(answer);
            serialNumberPanel.gameObject.SetActive(false);

            if (round.Starter.Mistakes < maxMistakeCount)
            {
                AddPointsToOverallScore(answer.Points);
            }
        }
    }

    private void AddPointsToOverallScore(int points)
    {
        RoundManager.Instance.AddToRoundScore(points);
        RoundScore.text = RoundManager.Instance.CurrentRound.Score.ToString();
    }

    private void RefreshTeamScoreText()
    {
        List<Team> teams = TeamManager.Instance.CurrentTeams;
        TeamOneScore.text = teams[0].Score.ToString();
        TeamTwoScore.text = teams[1].Score.ToString();
    }

    public void AwardScoreToTeam(int team)
    {
        TeamGroup teamGroup = (TeamGroup)team;
        TeamManager.Instance.AwardTeamScore(teamGroup);
        RefreshTeamScoreText();
        RoundScore.text = "0";
    }

    public void ResetOverallScore(int team)
    {
        RoundManager.Instance.ResetRoundScore();
        RoundScore.text = "0";
    }
}
