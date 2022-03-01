using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Round
{
    public int Id;
    public string Question;
    public List<Answer> Answers = new List<Answer>();
    public int Score { get; set; } = 0;
    public bool IsStolen { get; set; } = false;
    public List<Team> Teams { get; set; } = new List<Team>();
    public Team Starter { get; set; }
}

[Serializable]
public class RoundsList
{
    public List<Round> Rounds;
}
