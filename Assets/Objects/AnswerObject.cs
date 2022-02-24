using TMPro;
using UnityEngine;

public class AnswerObject : MonoBehaviour
{
    public TMP_Text AnswerText;
    public string Answer { get; set; }
    void Start()
    {
        Debug.Log($"got to answer object ----------------------------------- {Answer}");
        AnswerText.text = Answer;
    }
}
