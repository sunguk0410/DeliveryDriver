using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;


    void Update()
    {
        float steerAmout = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmout = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmout);
        transform.Translate(0, moveAmout, 0);     
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "SpeedUp") 
        {
            moveSpeed = boostSpeed;
        }
    } 

    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;    
    }
}
