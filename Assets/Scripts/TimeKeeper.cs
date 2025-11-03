using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeKeeper : MonoBehaviour
{
    Text timerText;
    [SerializeField] float time = 25f;

    void Start()
    {
        timerText = GetComponent<Text>();
    }


    void Update()
    {

        if (time <= 0 && Candy.CandyCounter != 11)
        {
            timerText.text = "Time Over!";
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            SceneManager.LoadScene("GameOver");
            Candy.CandyCounter = 0;
        }

        else if (time > 0 && Candy.CandyCounter == 11)
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
             Candy.CandyCounter = 0;
        }


        else
        {
            time -= Time.deltaTime;
            int timerVal = (int)time;
            timerText.text = "Time Remaining: " + timerVal;
        }

    }
}
