using UnityEngine;
using System.Collections;

public class barriere : MonoBehaviour {
		public Transform light;
		private Light pika;
		// Use this for initialization
		void Start () {
			//renderer.enabled (false);
			pika = light.GetComponent<Light> ();
		}
		
		// Update is called once per frame
		
		
		
		void OnTriggerEnter(Collider col)
		{
			
			pika.enabled = false;
			
			
			
		}
		
		void OnTriggerExit(Collider col)
		{
			pika.enabled = true;
		}
	}