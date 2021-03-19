using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject gameScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall" || other.tag == "BadCube" || other.tag == "Ground")
        {
            Time.timeScale = 0f;
            gameScreen.SetActive(false);
            gameOverScreen.SetActive(true);
        }
        
    }
}
