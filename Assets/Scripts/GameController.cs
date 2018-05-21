using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public GameObject player;

	// Use this for initialization
	void Start () {
		var destPrefs = PlayerPrefs.GetString("destination");
		if (destPrefs != "") {
			PlayerPrefs.SetString("destination", "");
			player.transform.position = GameObject.Find(destPrefs).transform.position;
			player.transform.rotation = GameObject.Find(destPrefs).transform.rotation;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}