using System.Collections.Generic;
using UnityEngine;

public class Room
{
    public string id { get; set; }
    public List<Team> teams { get; set; } = new List<Team>();
    public List<Round> rounds { get; set; } = new List<Round>();
}
