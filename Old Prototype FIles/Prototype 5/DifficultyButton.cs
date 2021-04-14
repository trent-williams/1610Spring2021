using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;

    public int difficuly;

    private void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        
        button.onClick.AddListener(SetDifficulty);
    }

    void SetDifficulty()
    {
        print(button.gameObject.name + " was clicked");
        gameManager.StartGame(difficuly);
    }
}
