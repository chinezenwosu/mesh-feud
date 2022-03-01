using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HostMenu : MonoBehaviour
{
    public void SelectGame(int game)
    {
        CreateRoom();
        RoundsList rounds = DataManager.ImportJson<RoundsList>($"game_{game}");
        SetRounds(rounds);

        SceneManager.LoadScene((int)BuildScene.Game);
    }

    public void CreateRoom()
    {
        RoomManager.Instance.CreateRoom();
    }

    public void SetRounds(RoundsList list)
    {
        RoomManager.Instance.SetRounds(list.Rounds);
        RoundManager.Instance.SetRound(list.Rounds[0]);
    }
}
