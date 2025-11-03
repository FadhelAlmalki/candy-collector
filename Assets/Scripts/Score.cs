using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    Text scoreText;
    int score = 0;

    void Start()
    {
        GetComponent<Text>().text = score.ToString();
    }

    public void IncreaseScore()
    {
        score++;
        GetComponent<Text>().text = score.ToString();
    }
}
