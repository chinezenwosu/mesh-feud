using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string Name { get; set; } = null;
    public Room Room { get; set; } = null;
    public Team Team { get; set; } = null;
    public bool IsHost { get; set; } = false;
}
