using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class distance_counter : MonoBehaviour
{

    public float targetTime = 60.0f;
    Text text;

    void Update()
    {

        targetTime -= Time.deltaTime;
        text.text = "TimeLeft:"  + targetTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        //do your stuff here.
    }
    void Awake()
    {
        text = GetComponent<Text>();


    }


}




