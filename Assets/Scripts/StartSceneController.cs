using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneController : MonoBehaviour
{
    public TMP_InputField playerNameInput;
    private string playerName = null;
    public Button characterBtn;
    public CharacterType character = CharacterType.Female;
    public GameObject selectPanel;

    public void OnJoinButtonClick()
    {
        playerName = playerNameInput.text;

        if (playerName.Length >= 2 && playerName.Length <= 10)
        {
            PlayerPrefs.SetString("PlayerName", playerName);
            PlayerPrefs.Save();

            SceneManager.LoadScene("MainScene");
        }
    }

    public void OnCharacterButtonClick()
    {
        selectPanel.SetActive(true);
    }
    
}
