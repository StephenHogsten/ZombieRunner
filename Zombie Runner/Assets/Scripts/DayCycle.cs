using UnityEngine;
using System.Collections;

public class DayCycle : MonoBehaviour {

	[Tooltip ("The number of minutes that pass each second")]
	public float timeScale = 60;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float angleThisFrame = - Time.deltaTime / 360 * timeScale;

		transform.RotateAround ( transform.position, Vector3.forward, angleThisFrame );
	
	}
}
