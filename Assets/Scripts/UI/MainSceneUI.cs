using System;
using TMPro;
using UnityEngine;

public class MainSceneUI : MonoBehaviour
{
    public TMP_Text timeText;
    public TMP_InputField inputField;
    public GameObject player;
    public GameObject nameChangePanel;

    private void Update()
    {
        timeText.text = DateTime.Now.ToString("HH : mm");
    }

    public void OnClickNameChangeButton()
    {
        if (inputField.text.Length < 2 || inputField.text.Length > 10)
        {
            return;
        }

        DataManager.instance.playerName = inputField.text;

        player.SetActive(true);
        nameChangePanel.SetActive(false);
    }

    public void OnClickClassChangeButton(int id)
    {
        DataManager.instance.classId = id;
    }
}
