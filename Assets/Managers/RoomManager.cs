using System;
using System.Collections.Generic;

public class RoomManager
{
    private static RoomManager _instance;
    public Room CurrentRoom { get; private set; }
    private Random generator = new Random();

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
        Team teamOne = new Team()
        {
            name = "Team 1"
        };
        Team teamTwo = new Team()
        {
            name = "Team 2"
        };

        Room room = new Room();
        string id = generator.Next(1, 10000).ToString("D4");
        room.id = id;
        room.teams.Add(teamOne);
        room.teams.Add(teamTwo);

        CurrentRoom = room;
    }

    public void SetRounds(List<Round> rounds)
    {
        EnsureRoomExists();
        CurrentRoom.rounds = rounds;
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
