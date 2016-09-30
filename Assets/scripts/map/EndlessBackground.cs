using UnityEngine;
using System.Collections;

public class EndlessBackground : MonoBehaviour {
	
		public float scrollSpeed;
		public float tileSizeZ;
    


		void Start ()
		{

		}

		void Update ()
		{

        transform.Translate(Vector3.left * Time.deltaTime * scrollSpeed);
        /*
			float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
			transform.position = Vector3.right * newPosition*/
		}
	}