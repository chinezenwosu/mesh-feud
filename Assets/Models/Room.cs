using System.Collections.Generic;
using UnityEngine;

public class Room
{
    public string Id { get; set; }
    public List<Team> Teams { get; set; } = new List<Team>();
}
