using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float x_movement;
	public float z_movement;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void LateUpdate() {
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * x_movement;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * z_movement;
		
		transform.Rotate(0,x,0);
		transform.Translate(0,0,z);	
	}
	
	void OnCollisionEnter(Collision col) {
		gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
	}
}
