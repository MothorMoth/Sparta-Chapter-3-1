using System;
using TMPro;
using UnityEngine;

public class MainSceneUI : MonoBehaviour
{
    public TMP_Text timeText;

    private void Update()
    {
        timeText.text = DateTime.Now.ToString("HH : mm");
    }
}
