using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Transform spawnParent;
	public bool respawnTrigger;

	private Transform[] spawnPoints;

	// Use this for initialization
	void Start () {
		spawnPoints = spawnParent.GetComponentsInChildren<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void ReSpawn() { 
		int i = Random.Range(1, spawnPoints.Length);
		transform.position = spawnPoints[i].position;
	}
}
