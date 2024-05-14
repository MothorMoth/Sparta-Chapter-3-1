using TMPro;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    public RuntimeAnimatorController[] animatorController;
    public Animator playerAnimator;
    public TMP_Text playerNameText;

    private void Start()
    {
        playerNameText.text = DataManager.instance.playerName;
        playerAnimator.runtimeAnimatorController = animatorController[DataManager.instance.classId];
    }
}
