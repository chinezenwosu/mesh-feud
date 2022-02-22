using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartAsPlayer()
    {
        SceneManager.LoadScene(1);
    }

    public void StartAsHost()
    {
        SceneManager.LoadScene(2);
    }
}
