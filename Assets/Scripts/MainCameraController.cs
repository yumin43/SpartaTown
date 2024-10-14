using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    public Transform player;

    public float followSpeed = 3.0f;
    public float offsetZ = -10.0f;
    
    public Vector2 offset;
    // Start is called before the first frame update
    private void FixedUpdate() 
    {
        Vector3 playerPos = new Vector3(player.position.x, player.position.y, offsetZ);
        transform.position = Vector3.Lerp(transform.position, playerPos, followSpeed);
    }
}
