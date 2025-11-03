using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    

    void Start()
    {
        
    }


    void Update()
    {
        Vector3 position = transform.position;

        position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        position.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.position = position;
    }
}