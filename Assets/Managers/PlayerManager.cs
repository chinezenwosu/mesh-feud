public class PlayerManager
{
    private static PlayerManager _instance;
    public Player CurrentPlayer { get; private set; }

    public static PlayerManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new PlayerManager();
            }
            return _instance;
        }
    }

    private PlayerManager() {}

    public void CreatePlayer(string name, Room room, Team team)
    {
        Player player = new Player()
        {
            Name = name,
            Room = room,
            Team = team
        };
        CurrentPlayer = player;
    }
}
