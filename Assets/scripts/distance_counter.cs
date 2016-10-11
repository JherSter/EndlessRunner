using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class distance_counter : MonoBehaviour{

    public float distance;
    public Transform player;
    public static int score;

    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        score = 0;

        distance = Vector3.Distance(player.position, transform.position);
    }
    void Update()
    {
        Score();
        Debug.Log ("joer");

        text.text = "Score:" + score;
    }

    void Score()
    {
        distance = Vector3.Distance(player.position, transform.position);

        //Debug.Log(player.position);
        //Debug.Log(transform.position);

        score = Mathf.RoundToInt(distance);
    }

}