using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public GameObject player;
	
	private bool gameOver;
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
		} else {
			currentTime = 1;
			gameOver = false;
		 }
		InvokeRepeating("UpdateEndTimer", 0.1f, 25.83333f);
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver) {
			print("Huzzah!");
		}
	}
	
	void UpdateEndTimer() {
		currentTime++;
		if (currentTime == 12) {
			gameOver = true;
			currentTime = 0;
			return;
		}
		foreach(var timer in GameObject.FindGameObjectsWithTag("EndTimer")) {
			timer.GetComponent<TextMesh>().text = currentTime.ToString();
		}
		PlayerPrefs.SetInt("endTimer", currentTime);
	}
}