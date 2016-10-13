using UnityEngine;
using System.Collections;

public class EndlessBackground : MonoBehaviour {
	
		public float scrollSpeed;
    
		void Start ()
		{

		}

		void Update ()
		{

        transform.Translate(Vector3.right * Time.deltaTime * scrollSpeed);
        
		
		}
	}