using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorLightController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var rand = Random.Range (-9, 14);
		foreach (Light l in gameObject.GetComponentsInChildren<Light>()) {
			if (rand > -3 && rand < 2) {
				l.enabled = false;
			} else {
				l.enabled = true;
			}
		}
	}
}
