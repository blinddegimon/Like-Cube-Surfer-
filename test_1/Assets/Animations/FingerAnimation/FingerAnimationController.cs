using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerAnimationController : MonoBehaviour
{
    
    private void Awake()
    {
        GetComponent<Animation>().Play("Finger");
    }
}
