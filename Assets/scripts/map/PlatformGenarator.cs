using UnityEngine;
using System.Collections;

public class PlatformGenarator : MonoBehaviour {

    public int maxPlatforms = 1;
    public GameObject platform;
    public float horizontalMin = 4;
    public float horizontalMax = 2;
    public float verticalMin = -6f;
    public float verticalMax = 6;
    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;
     private float platformWidth;
	private float random;
	private float landom;
	[SerializeField]
	private GameObject Pickupl;
	[SerializeField]
	private GameObject Spikes;

    private Vector2 originPosition;


    void Start () {

        originPosition = transform.position;
        Spawn ();
         platformWidth = thePlatform.GetComponent<BoxCollider>().size.x;

    
    }

    void Spawn()
    {
        for (int i = 0; i < maxPlatforms; i++)
        {
            //Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin, horizontalMax), Random.Range (verticalMin, verticalMax));
            //Instantiate(platform, randomPosition, Quaternion.identity);
            //originPosition = randomPosition;
        }
    }
    void Update () {
		if (originPosition.x < generationPoint.position.x) {
			Vector2 randomPosition = originPosition + new Vector2 (Random.Range (horizontalMin, horizontalMax), Random.Range (verticalMin, verticalMax));
			transform.position = new Vector3 (transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);
			Instantiate (platform, randomPosition, transform.rotation);
			//Instantiate(platform, randomPosition, Quaternion.identity);
			originPosition = randomPosition;
			random = Random.value * 100f;
			landom = Random.value * 100f;

			if (random < 10) {
				Instantiate (Pickupl, new Vector2(randomPosition.x, randomPosition.y + 2f), transform.rotation);

				Debug.Log ("Pickup");
			}

				

			if (landom < 30) {
				Instantiate (Spikes, new Vector2(randomPosition.x + 1f, randomPosition.y + 1f), transform.rotation);

				Debug.Log ("spikes");



			}
		}
	}


	
}
