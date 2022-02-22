using System;

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
            Name = "Team 1"
        };
        Team teamTwo = new Team()
        {
            Name = "Team 2"
        };

        Room room = new Room();
        string id = generator.Next(1, 10000).ToString("D4");
        room.Id = id;
        room.Teams.Add(teamOne);
        room.Teams.Add(teamTwo);

        CurrentRoom = room;
    }

    public void ExitRoom()
    {
        CurrentRoom = null;
    }
}
