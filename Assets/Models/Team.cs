using System.Collections.Generic;

public enum TeamGroup
{
    One,
    Two
}

public class Team
{
    public string Name { get; set; } = string.Empty;
    public int Score { get; set; } = 0;
    public List<Player> Players { get; set; } = new List<Player>();
    public int Mistakes { get; set; } = 0;
}
