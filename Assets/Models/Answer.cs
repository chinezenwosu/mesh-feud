using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer
{
    public int points { get; set; } = 0;
    public string text { get; set; } = string.Empty;
    public Question question { get; set; } = null;
    public bool revealed { get; set; } = false;
}
