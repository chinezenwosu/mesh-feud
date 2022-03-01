using System;
using System.Collections.Generic;

public class RoomManager
{
    private static RoomManager _instance;
    public Room CurrentRoom { get; private set; }

    public static RoomManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new RoomManager();
            }
            return _instance;
        }
    }

    private RoomManager() { }

    public void CreateRoom()
    {
        TeamManager.Instance.CreateTeams();
        Room room = new Room();
        string id = GenerateRoomId();
        room.Id = id;
        room.Teams = TeamManager.Instance.CurrentTeams;
        CurrentRoom = room;
    }

    private string GenerateRoomId()
    {
        Random generator = new Random();
        return generator.Next(1, 10000).ToString("D4");
    }

    public void SetRounds(List<Round> rounds)
    {
        EnsureRoomExists();
        CurrentRoom.Rounds = rounds;
    }

    private void EnsureRoomExists()
    {
        if (CurrentRoom == null)
        {
            CreateRoom();
        }
    }

    public void ExitRoom()
    {
        CurrentRoom = null;
    }
}
