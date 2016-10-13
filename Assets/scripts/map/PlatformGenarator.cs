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
		if (transform.position.x < generationPoint.position.x) {
			Vector2 randomPosition = originPosition + new Vector2 (Random.Range (horizontalMin, horizontalMax), Random.Range (verticalMin, verticalMax));
			transform.position = new Vector3 (transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);
			Instantiate (platform, randomPosition, transform.rotation);
			//Instantiate(platform, randomPosition, Quaternion.identity);
			originPosition = randomPosition;
			random = Random.value * 100f;
			landom = Random.value * 100f;

			if (random < 10) {
				Pickupl.gameObject.SetActive (true);
				Invoke ("Deactivate", 10f);

				Debug.Log ("lol");

			}if (landom < 30) {
				Spikes.gameObject.SetActive (true);
				Invoke("Deactivate",10f );

				Debug.Log ("LOL");



			}
		}
	}
	void Deactivate(){
		Spikes.gameObject.SetActive (false);
		Pickupl.gameObject.SetActive (false);
	}
	void OnBecameInvisible(){
		Destroy (gameObject);
	}
	
}
