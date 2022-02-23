using UnityEngine;
using UnityEngine.SceneManagement;

public enum BuildScene
{
    StartMenu,
    PlayerMenu,
    HostMenu,
    Game
}

public class StartMenu : MonoBehaviour
{
    public void StartAsPlayer()
    {
        PlayerManager.Instance.CreatePlayer();
        SceneManager.LoadScene((int)BuildScene.PlayerMenu);
    }

    public void StartAsHost()
    {
        PlayerManager.Instance.CreatePlayer("Host");
        PlayerManager.Instance.ActAsHost();
        SceneManager.LoadScene((int)BuildScene.HostMenu);
    }
}
