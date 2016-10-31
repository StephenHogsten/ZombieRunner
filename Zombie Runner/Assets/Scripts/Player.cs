using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Transform spawnParent;
	public AudioClip whatHappened;
	//public AudioClip 

	private Transform[] spawnPoints;
	private Helicopter helicopter;
	private AudioSource internalAudioSource;

	// Use this for initialization
	void Start () {
		helicopter = FindObjectOfType<Helicopter>();
		foreach (AudioSource a in GetComponents<AudioSource>()) {
			if (a.spatialBlend == 0f) {
				internalAudioSource = a;
			}
		}
		internalAudioSource.clip = whatHappened;
		internalAudioSource.Play();

		Debug.Log(internalAudioSource.name + " " + internalAudioSource.spatialBlend);

		spawnPoints = spawnParent.GetComponentsInChildren<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void ReSpawn() { 
		int i = Random.Range(1, spawnPoints.Length);
		transform.position = spawnPoints[i].position;
	}

	void OnFindClearArea() {
		Debug.Log("Found a clear area");
		helicopter.ReceiveCall();

		//TODO make flares
		//TODO start spawning Zombos
	}
}
