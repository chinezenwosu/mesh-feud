using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question
{
    public string Id { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public List<Answer> Answers { get; set; } = new List<Answer>();
}
