using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class IntroUI : MonoBehaviour
{
    public TMP_InputField inputField;

    public void OnClickButton()
    {
        if (inputField.text.Length < 2 || inputField.text.Length > 10)
        {
            return;
        }

        DataManager.instance.playerName = inputField.text;

        SceneManager.LoadScene(1);
    }
}
