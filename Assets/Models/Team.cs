using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team
{
    public string Name { get; set; } = string.Empty;
    public int Score { get; set; } = 0;
    public List<Player> Players { get; set; } = new List<Player>();
}
