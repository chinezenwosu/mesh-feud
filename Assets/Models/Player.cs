using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string Name { get; set; }
    public Room Room { get; set; }
    public Team Team { get; set; }
    public bool IsHost { get; set; } = false;
}
