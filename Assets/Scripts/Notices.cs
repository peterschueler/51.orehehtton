using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Notices : MonoBehaviour {
	public string scene;
	public float sceneDelay;

	// Use this for initialization
	void Start () {
		Screen.fullScreen = false;
		StartCoroutine(LoadSceneAfterTime(sceneDelay));
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	IEnumerator LoadSceneAfterTime(float time) {
		yield return new WaitForSeconds(time);
		SceneManager.LoadScene(scene);
	}
}
