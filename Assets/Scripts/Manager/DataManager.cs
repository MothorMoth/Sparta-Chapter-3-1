using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public string playerName;
    public int classId;
    public string NPCName = "신우석 매니저님";

    private void Awake()
    {
        if (instance == null)
        { 
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
