using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClydeTrigger : MonoBehaviour {
	public GameObject clyde;
	public AudioSource clydeSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void ActivateClyde() {
		clyde.SetActive(true);
		clydeSound.Play();
	}
	
	void OnTriggerEnter(Collider col) {
		ActivateClyde();
	}
}