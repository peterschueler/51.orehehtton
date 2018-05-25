using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheaterTrigger : MonoBehaviour {
	public GameObject[] lights;
	public GameObject timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider col) {
		print("triggered");
		foreach(var g in lights) {
			g.SetActive(true);
		}
		timer.GetComponent<MeshRenderer>().enabled = true;
	}
}
