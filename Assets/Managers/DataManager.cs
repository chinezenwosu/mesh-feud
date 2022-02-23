using UnityEngine;
 
public class DataManager : MonoBehaviour
{
    public static T ImportJson<T>(string fileName)
    {
        TextAsset textAsset = Resources.Load<TextAsset>($"Json/{fileName}");
        return JsonUtility.FromJson<T>(textAsset.text);
    }
}
