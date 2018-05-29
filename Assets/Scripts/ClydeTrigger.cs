using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClydeTrigger : MonoBehaviour {
	public GameObject clyde;
	public AudioSource clydeSound;
	public GameObject[] lights;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	IEnumerator ExecuteAfterTime(float time, bool yes) {
		yield return new WaitForSeconds(time);
		if (yes) {
			clydeSound.Play();
		} else {
			clydeSound.Stop();
		}
		foreach (var l in lights) {
			l.SetActive(yes);
		}
	}
	
	void OnTriggerEnter(Collider col) {
		clyde.SetActive(true);
		float timer = 0.0f;
		bool yes = true;
		while (timer < 6) {
			StartCoroutine(ExecuteAfterTime(timer, yes));
			if (yes) {
				yes = false;
			} else {
				yes = true;
			}
			timer += 0.3f;
		}
	}
	
	void OnTriggerExit(Collider col) {
		clyde.SetActive(false);
	}
}