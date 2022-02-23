using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Round
{
    public string question = string.Empty;
    public List<Answer> answers = new List<Answer>();
    public int score { get; set; } = 0;
}

[Serializable]
public class Rounds
{
    public List<Round> rounds;
}
