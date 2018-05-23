using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
	public GameObject[] tapes;
	public GameObject[] glitches;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		foreach (var r in tapes) {
			r.transform.Rotate(0,0,20*Time.deltaTime);
		}
		var rand = Random.Range (-9, 14);
		foreach(var g in glitches) {
			if (rand > -3 && rand < 2) {
				g.SetActive(false);
			} else {
				g.SetActive(true);
			}
		}
	}
}
