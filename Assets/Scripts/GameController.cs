using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public GameObject player;
	
	private int currentTime;

	// Use this for initialization
	void Start () {
		var destPrefs = PlayerPrefs.GetString("destination");
		if (destPrefs != "") {
			PlayerPrefs.SetString("destination", "");
			player.transform.position = GameObject.Find(destPrefs).transform.position;
			player.transform.rotation = GameObject.Find(destPrefs).transform.rotation;
		}
		var t = PlayerPrefs.GetInt("endTimer");
		if (t != 0) {
			currentTime = t;
			print("helloooo");
		} else {
			currentTime = 1;
		 }
		InvokeRepeating("UpdateEndTimer", 0.1f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void UpdateEndTimer() {
		var timer = GameObject.Find("EndTimer");
		currentTime++;
		timer.GetComponent<TextMesh>().text = currentTime.ToString();
		PlayerPrefs.SetInt("endTimer", currentTime);
	}
}