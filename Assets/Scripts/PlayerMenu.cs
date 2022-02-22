using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMenu : MonoBehaviour
{
    public Input Name;
    public Input Room;
    public Button TeamOneButton;
    public Button TeamTwoButton;
    private TeamGroup teamGroup = TeamGroup.One;

    private void Start()
    {
        SelectTeam((int)teamGroup);
    }

    private enum TeamGroup
    {
        One,
        Two
    }

    public void Submit()
    {
        SceneManager.LoadScene(2);
    }

    public void SelectTeam(int team)
    {
        teamGroup = (TeamGroup)team;
        StyleSelectedButton(TeamOneButton, teamGroup == TeamGroup.One);
        StyleSelectedButton(TeamTwoButton, teamGroup == TeamGroup.Two);
    }

    private void StyleSelectedButton(Button button, bool selected)
    {
        Color selectedColor = new Color32(141, 187, 200, 40);
        Color unselectedColor = new Color32(10, 152, 190, 20);
        FontStyles selectedFontStyle = FontStyles.Bold;
        FontStyles unselectedFontStyle = FontStyles.Normal;

        Color color = unselectedColor;
        FontStyles fontStyle = unselectedFontStyle;

        if (selected)
        {
            color = selectedColor;
            fontStyle = selectedFontStyle;
        }

        Image buttonImage = button.gameObject.GetComponent<Image>();
        if (buttonImage != null)
        {
            buttonImage.color = color;
        }

        TMP_Text buttonText = button.gameObject.GetComponentInChildren<TMP_Text>();
        if (buttonText != null)
        {
            buttonText.fontStyle = fontStyle;
        }
    }
}
