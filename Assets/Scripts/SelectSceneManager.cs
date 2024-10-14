using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class SelectSceneManager : MonoBehaviour
{
    public CharacterType characterType;
    public GameObject selectPanel;

    public void OnSelectButtonClick()
    {
        DataManager.instance.currentCharacterType = characterType;
        selectPanel.SetActive(false);
    }
}
