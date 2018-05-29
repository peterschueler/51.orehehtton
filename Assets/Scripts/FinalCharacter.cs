using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCharacter : MonoBehaviour {
	public Vector3 teleportPoint;
	public float speed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine(MoveIntoTheLight(8));
		StartCoroutine(Endgame(16));
	}
	
	IEnumerator MoveIntoTheLight(float time) {
		yield return new WaitForSeconds(time);
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, teleportPoint, step);
	}
	
	IEnumerator Endgame(float time) {
		yield return new WaitForSeconds(time);
		Application.Quit();
	}
}
