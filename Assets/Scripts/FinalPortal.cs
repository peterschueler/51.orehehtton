using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalPortal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider col) {
		var t = PlayerPrefs.GetInt("endTimer");
		if (t == 12) {
			SceneManager.LoadScene("Final");
		} else {
			SceneManager.LoadScene("One");
		}
	}
}