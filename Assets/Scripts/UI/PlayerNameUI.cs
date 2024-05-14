using TMPro;
using UnityEngine;

public class PlayerNameUI : MonoBehaviour
{
    private TMP_Text _playerNameText;

    private void Start()
    {
        _playerNameText = GetComponent<TMP_Text>();
        _playerNameText.text = DataManager.instance.playerName;
    }

    //private void OnEnable()
    //{
    //    _playerNameText.text = DataManager.instance.playerName;
    //}
}
