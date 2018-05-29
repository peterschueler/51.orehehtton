using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public GameObject player;
	private int currentTime = 1;

	// Use this for initialization
	void Start () {
		var destPrefs = PlayerPrefs.GetString("destination");
		if (destPrefs != "") {
			PlayerPrefs.SetString("destination", "");
			player.transform.position = GameObject.Find(destPrefs).transform.position;
			player.transform.rotation = GameObject.Find(destPrefs).transform.rotation;
		}
	}
	
	private void Awake() {
		if (PlayerPrefs.HasKey("endTimer")) {
			var t = PlayerPrefs.GetInt("endTimer");
			if (t != 0) {
				currentTime = t;
			}
		} else {
			PlayerPrefs.SetInt("endTimer", 1);
			PlayerPrefs.Save();
		}
		InvokeRepeating("UpdateEndTimer", 0.1f, 25.83333f);
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void UpdateEndTimer() {
		if (currentTime == 12) {
			return;
		}
		currentTime++;
		foreach(var timer in GameObject.FindGameObjectsWithTag("EndTimer")) {
			timer.GetComponent<TextMesh>().text = currentTime.ToString();
		}
		PlayerPrefs.SetInt("endTimer", currentTime);
		PlayerPrefs.Save();
	}
	
	void OnApplicationQuit() {
		PlayerPrefs.SetInt("endTimer", 0);
	}
}