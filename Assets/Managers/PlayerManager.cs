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

    public void CreatePlayer(string name = null)
    {
        Player player = new Player()
        {
            name = name,
        };
        CurrentPlayer = player;
    }

    private void EnsurePlayerExists()
    {
        if (CurrentPlayer == null)
        {
            CreatePlayer();
        }
    }

    public void ActAsHost()
    {
        EnsurePlayerExists();
        CurrentPlayer.isHost = true;
    }
    public void SetPlayerName(string name)
    {
        EnsurePlayerExists();
        CurrentPlayer.name = name;
    }

    public void AddPlayerToTeam(Team team)
    {
        EnsurePlayerExists();
        CurrentPlayer.team = team;
    }

    public void AddPlayerToRoom(Room room)
    {
        EnsurePlayerExists();
        CurrentPlayer.room = room;
    }
}
