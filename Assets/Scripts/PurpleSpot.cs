using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleSpot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating("MoveSpot", 0.1f, 0.2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void MoveSpot() {
		var rand_x = Random.Range(-90, 100);
		var rand_y = Random.Range(0, 30);
		var rand_z = Random.Range(-140, 60);
		transform.position = new Vector3((float)rand_x, (float)rand_y, (float)rand_z);
	}
}
