using UnityEngine;
using System.Collections;
public class trigger : MonoBehaviour {
	public Transform light;
	private Light pikachu;
	// Use this for initialization
	void Start () {
		//renderer.enabled (false);
		pikachu = light.GetComponent<Light> ();
	}
	
	// Update is called once per frame

		

	void OnTriggerEnter(Collider col)
	{

			pikachu.enabled = false;

			

	}

	void OnTriggerExit(Collider col)
	{
				pikachu.enabled = true;
		}
}
