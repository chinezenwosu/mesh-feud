using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string name { get; set; } = null;
    public Room room { get; set; } = null;
    public Team team { get; set; } = null;
    public bool isHost { get; set; } = false;
}
