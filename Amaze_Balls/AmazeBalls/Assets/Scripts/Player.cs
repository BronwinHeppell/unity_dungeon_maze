using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int _coins;

    private static Player _instance;
    public static Player Instance
    {
        get {
        
            if (_instance == null)
            {
                Debug.LogError("Player is null");
            }
            return _instance;
        }
    }

    private void Start()
    {
        _coins = 0;
    }

    private void Update()
    {
    }

    private void Awake()
    {
        _instance = this;
    }

    public void AddCoins()
    {
        _coins++;

        FindObjectOfType<UIManager>().UpdateCoinText(_coins);
    }

}
