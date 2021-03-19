using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExtraCubesVisual : MonoBehaviour
{
    public Move_1 move;

    public GameObject ExtraCubePrefab;

    public float damping = 10f;

    private GameObject prefab;

    private Animator animator;


    
    private void Start()
    {
        move = FindObjectOfType<Move_1>();
        
        animator = transform.parent.gameObject.GetComponent<Animator>();
    }

    private void FixedUpdate() 
    {
        animator.SetBool("isHitting", false);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "ExtraCube")
        {
            Destroy(other.gameObject);
            spawnPrefab();
        }
        else if (other.tag == "BadCube")
        {
            transform.parent = null;
            other.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            Destroy(this.gameObject);
        }
        else if (other.tag == "TurnRight")
        {
            turnRight();
            other.GetComponent<BoxCollider>().isTrigger = false;
        }
        else if (other.tag == "TurnLeft")
        {
            turnLeft();
            other.GetComponent<BoxCollider>().isTrigger = false;
        }
        else if (other.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
        else if (other.tag == "Coin") {
            move.updateCoinCounter();
            Destroy(other.gameObject);
        }  

    }
    
    private void spawnPrefab()
    {
        animator.SetBool("isHitting", true);

        transform.parent.position = new Vector3(transform.parent.position.x,
                                                transform.parent.position.y+1,
                                                transform.parent.position.z);
        prefab = Instantiate(ExtraCubePrefab, new Vector3(transform.position.x,
                                                          0.5f,
                                                          transform.position.z), Quaternion.identity);
        prefab.transform.parent = transform.parent;
        
    }

    private void turnRight() {
        transform.parent.rotation = Quaternion.AngleAxis(transform.parent.rotation.eulerAngles.y+90, Vector3.up);
    }

    private void turnLeft()
    {
        transform.parent.rotation = Quaternion.AngleAxis(transform.parent.rotation.eulerAngles.y-90, Vector3.up);
    }
}
