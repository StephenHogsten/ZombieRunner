using UnityEngine;
using System.Collections;

public class LandingArea : MonoBehaviour {

	[Tooltip ("Number of collision free seconds after we trigger the clear sound")]
	public float clearThreshold = 1;
	[Tooltip ("Number of seconds between sound triggers")]
	public bool hasCalledHelicopter;
	public AudioClip areaClearClip;

	private float lastCollision;
	private Collider playerCollider;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		lastCollision = Time.time;
		playerCollider = GetComponentInParent<Player>().GetComponent<Collider>();
		audioSource = GetComponent<AudioSource>();

		//Debug.Log("player collider: " + playerCollider.name);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.realtimeSinceStartup > 15) {
			if (Time.time - lastCollision >= clearThreshold && !hasCalledHelicopter) {
				hasCalledHelicopter = true;
				audioSource.PlayOneShot(areaClearClip);
				SendMessageUpwards( "OnFindClearArea" );
			}
		}
	}

	void OnTriggerStay(Collider collider) {
		if (collider != playerCollider) {
			Debug.Log("non-player collision with " + collider.name);
			lastCollision = Time.time;
		}
	}
}
