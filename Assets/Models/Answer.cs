using System;

[Serializable]
public class Answer
{
    public int Points = 0;
    public string Text;
    public bool Revealed { get; set; } = false;
}
