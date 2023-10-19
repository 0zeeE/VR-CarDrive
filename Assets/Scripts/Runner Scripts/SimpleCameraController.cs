using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    private float yOffset = 2;
    private float zOffset = -4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void LateUpdate()
    {
        transform.position = new Vector3(player.position.x,player.position.y + yOffset,player.position.z + zOffset);
    }
}
