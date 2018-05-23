using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ClydeTrigger : MonoBehaviour {
	public GameObject clyde;
	public GameObject[] lights;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider col) {
		clyde.SetActive(true);
		foreach (var l in lights) {
			l.SetActive(true);
		}
	}
}
