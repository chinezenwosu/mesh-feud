using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team
{
    public string name { get; set; } = string.Empty;
    public int score { get; set; } = 0;
    public List<Player> players { get; set; } = new List<Player>();
}
