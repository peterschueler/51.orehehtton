using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderTrigger : MonoBehaviour {
	public GameObject[] renderObjects;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter(Collider col) {
		foreach(var obj in renderObjects) {
			if (obj.GetComponent<Renderer>().enabled) {
				obj.GetComponent<Renderer>().enabled = false;
			} else {
				obj.GetComponent<Renderer>().enabled = true;
			}
		}
	}
}
