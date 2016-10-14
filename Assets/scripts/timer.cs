using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{

    public float targetTime = 20.0f;
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
        Application.LoadLevel("main menu");
        //do your stuff here.
    }
    void Awake()
    {
        text = GetComponent<Text>();


    }


}




