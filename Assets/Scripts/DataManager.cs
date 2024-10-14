using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.TextCore.Text;

public enum CharacterType
{
    Female, 
    Male
}

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    public CharacterType currentCharacterType;
    
    private void Awake() 
    {
        if (instance == null) 
        { 
            instance = this;
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
