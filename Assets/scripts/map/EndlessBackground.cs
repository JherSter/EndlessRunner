using UnityEngine;
using System.Collections;

public class EndlessBackground : MonoBehaviour {
	
		public float scrollSpeed;
		public float tileSizeZ;

		private Vector3 startPosition;


		void Start ()
		{
			startPosition = transform.position;

		}

		void Update ()
		{

        transform.Translate(Vector3.left * Time.deltaTime * scrollSpeed);
        /*
			float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
			transform.position = Vector3.right * newPosition*/
		}
	}