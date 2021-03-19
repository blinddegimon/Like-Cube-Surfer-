using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float xOffset = -8;
    public float yOffset = 6;
    public float zOffset = -3;

    private float startFoV = 60.0f;
    private Camera camera;
    void Start()
    {
        camera = this.GetComponent<Camera>();
    }

    void FixedUpdate()
    {
        camera.fieldOfView = startFoV + player.position.y * 4;
    }
}
