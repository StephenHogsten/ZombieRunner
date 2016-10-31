using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour {

	public AudioClip helicopterCall;

	private AudioSource audioSource;
	private bool hasCalledHelicopter;
	private Rigidbody rigidBody;
	private AudioClip initalSound;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
		rigidBody = GetComponent<Rigidbody>();

		initalSound = audioSource.clip;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Call Helicopter") && !hasCalledHelicopter) {
			ReceiveCall();
		}
	}

	void ResetAudio() {
		audioSource.spatialBlend = 1f;
		audioSource.clip = initalSound;
	}

	public void ReceiveCall() {
		if (!hasCalledHelicopter) {
			hasCalledHelicopter = true;
			audioSource.spatialBlend = 0f;
			audioSource.PlayOneShot(helicopterCall);
			Invoke( "ResetAudio", helicopterCall.length);

			rigidBody.velocity = new Vector3( 0, 0, 50f );
		}
	}
}
