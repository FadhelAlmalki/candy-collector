using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    public static int CandyCounter = 0;

    public void OnTriggerEnter2D(Collider2D other)
    {

        Destroy(gameObject);
        FindObjectOfType<Score>().IncreaseScore();
        CandyCounter += 1;
    }
}
