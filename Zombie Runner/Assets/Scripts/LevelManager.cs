using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadLevel(string level) {
		SceneManager.LoadScene( level );
	}

	public void RequestQuit() {
		Application.Quit();
	}
}
