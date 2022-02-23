using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMenu : MonoBehaviour
{
    private string playerName;
    private string roomId;
    private TeamGroup teamGroup = TeamGroup.One;
    public InputField NameInput;
    public InputField RoomInput;
    public Button TeamOneButton;
    public Button TeamTwoButton;

    private enum TeamGroup
    {
        One,
        Two
    }

    private void Start()
    {
        SelectTeam((int)teamGroup);

        NameInput.onValueChanged.AddListener(OnNameChanged);
        RoomInput.onValueChanged.AddListener(OnRoomChanged);
    }

    private void OnNameChanged(string value)
    {
        playerName = value;
    }
    
    private void OnRoomChanged(string value)
    {
        roomId = value;
    }

    public void Submit()
    {
        // This should add player to room created by host but we are hardcoding this for now
        RoomManager.Instance.CreateRoom();
        Room dummyRoom = RoomManager.Instance.CurrentRoom;

        PlayerManager.Instance.SetPlayerName(playerName);
        PlayerManager.Instance.AddPlayerToRoom(dummyRoom);
        PlayerManager.Instance.AddPlayerToTeam(dummyRoom.teams[(int)teamGroup]);
        SceneManager.LoadScene((int)BuildScene.Game);
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
