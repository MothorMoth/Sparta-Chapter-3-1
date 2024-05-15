using TMPro;
using UnityEngine;

public class NonPlayerCharacter : MonoBehaviour
{
    public TMP_Text NPCNameText;

    private void Start()
    {
        NPCNameText.text = DataManager.instance.NPCName;
    }
}
