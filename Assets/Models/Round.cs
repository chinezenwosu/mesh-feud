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
}

[Serializable]
public class RoundsList
{
    public List<Round> Rounds;
}
