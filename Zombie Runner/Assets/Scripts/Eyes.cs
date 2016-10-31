using UnityEngine;
using System.Collections;

public class Eyes : MonoBehaviour {

	private Camera eyes;
	private float defaultFOV;
	private bool isZoomed;


	// Use this for initialization
	void Start () {
		eyes = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Zoom")){
			isZoomed = !isZoomed;
			if (isZoomed) { eyes.fieldOfView /= 1.5f; }
			else 		  { eyes.fieldOfView *= 1.5f; }
		}
	}
}
