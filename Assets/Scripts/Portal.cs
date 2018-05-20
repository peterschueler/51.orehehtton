using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {
	public bool local;
	public System.String destination;
	public System.String scene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter(Collider col) {
		if (local) {
			var dest = GameObject.Find(destination);
			col.gameObject.transform.position = dest.transform.position;
		} else {
			PlayerPrefs.SetString("destination", destination);
			SceneManager.LoadScene(scene);
		}
	}
}