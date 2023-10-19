using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform carTransform;
    [SerializeField] private Rigidbody carRb;
    [SerializeField] private float moveSpeed = 20f;
    public bool isrotated = false;
   
    void Start()
    {
        
        carTransform = this.gameObject.transform;
        carRb = this.gameObject.GetComponent<Rigidbody>();
        MoveTheCar();
    }

    // Update is called once per frame
    void Update()
    {
        DestroySelf();
        MoveTheCar();
    }

    public void MoveTheCar()
    {
        if(isrotated)
        {
            carTransform.Translate(carTransform.forward * moveSpeed * Time.deltaTime);
        }
        else
        {
            carTransform.Translate(carTransform.forward * -moveSpeed * Time.deltaTime);
        }
        //carRb.AddForce(carTransform.forward * -moveSpeed * Time.deltaTime);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player" || collision.collider.tag == "Obstacle")
            moveSpeed = 0f;
    }

    private void DestroySelf()
    {
        Destroy(this.gameObject,30f);
    }



}
