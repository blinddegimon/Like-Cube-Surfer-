using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPassed : MonoBehaviour
{
    public GameObject gameScreen;
    public GameObject levelPassedScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            Time.timeScale = 0f;
            gameScreen.SetActive(false);
            levelPassedScreen.SetActive(true);
        }
    }
}
