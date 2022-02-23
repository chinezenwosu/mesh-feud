using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HostMenu : MonoBehaviour
{
    public Button GameOneButton;
    public Button GameTwoButton;
    public Button GameThreeButton;
    public Button GameFourButton;

    private enum Game
    {
        One,
        Two,
        Three,
        Four
    }

    public void SelectGame(int game)
    {
        CreateRoom();
        Rounds rounds = DataManager.ImportJson<Rounds>($"game_{game}");
        SetRounds(rounds);

        SceneManager.LoadScene((int)BuildScene.Game);
    }

    public void CreateRoom()
    {
        RoomManager.Instance.CreateRoom();
    }

    public void SetRounds(Rounds rounds)
    {
        RoomManager.Instance.SetRounds(rounds.rounds);
    }
}
