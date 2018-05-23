using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClydeLightTrigger : MonoBehaviour {
	public GameObject[] lights;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider col) {
		foreach (var l in lights) {
			l.SetActive(true);
		}
	}
}
