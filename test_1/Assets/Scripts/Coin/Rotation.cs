using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speedRotation = 2f;
    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(0,speedRotation,0));  
    }
}
