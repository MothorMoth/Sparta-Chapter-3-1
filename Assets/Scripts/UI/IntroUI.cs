using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class IntroUI : MonoBehaviour
{
    public TMP_InputField inputField;
    public Sprite[] classSprites;
    public Image selectedClass;

    public void ChoiceClass(int id)
    {
        selectedClass.sprite = classSprites[id];
        DataManager.instance.classId = id;
    }

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
