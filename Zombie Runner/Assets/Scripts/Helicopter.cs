using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour {

	public AudioClip helicopterCall;

	private AudioSource audioSource;
	private bool hasCalledHelicopter;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Call Helicopter") && !hasCalledHelicopter) {
			hasCalledHelicopter = true;
			AudioClip currentClip = audioSource.clip;
			audioSource.spatialBlend = 0f;
			audioSource.PlayOneShot(helicopterCall);

			Invoke( "Reset3dSound", helicopterCall.length);
		}
	}

	void Reset3dSound() {
		audioSource.spatialBlend = 1f;
	}
}
