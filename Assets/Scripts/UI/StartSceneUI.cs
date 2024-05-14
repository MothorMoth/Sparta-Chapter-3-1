using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class StartSceneUI : MonoBehaviour
{
    public Sprite[] classSprites;
    public Image selectedClass;
    public TMP_InputField inputField;

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
