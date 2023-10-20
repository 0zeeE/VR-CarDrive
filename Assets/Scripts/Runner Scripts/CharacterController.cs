using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Start is called before the first frame update
    public SpawnManager spawnManager;

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            spawnManager.SpawnTriggerEntered();
            Debug.Log("Colliding");
        }



    }
}
