using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject gameScreen;
    public GameObject gameOverScreen;
    public GameObject levelPassedScreen;
    public Move_1 move;

    void Start()
    {
        move = FindObjectOfType<Move_1>();
        move.forwardSpeed = 0;
        startScreen.SetActive(true);
        gameScreen.SetActive(false);
        gameOverScreen.SetActive(false);
        levelPassedScreen.SetActive(false);
        //Time.timeScale = 0f;
    }

    public void startGame() {
        move.forwardSpeed = 5;
        startScreen.SetActive(false);
        gameScreen.SetActive(true);
        //Time.timeScale = 1f;
    }
    void Update()
    {
        
    }
}
