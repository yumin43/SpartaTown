using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerNameDisplay : MonoBehaviour
{
    public TMP_Text playerNameTxt;

    // Start is called before the first frame update
    void Start()
    {
        playerNameTxt.text = PlayerPrefs.GetString("PlayerName", "PlayerName");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
