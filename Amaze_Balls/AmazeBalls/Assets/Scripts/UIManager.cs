using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    private static UIManager _instance;

    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("UIManager is null"); 
            }
            return _instance;
        }
    }
 
    private void Awake()
    {
        _instance = this;
    }
    public void UpdateCoinText(int coins)
    {
        if (_instance != null)
        {
            coinText.text = "Coins: " + coins;
        }
    }
}
