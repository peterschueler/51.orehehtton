using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour {
	public GameObject caption;
	public ParticleSystem effect;
	public GameObject moodLight;
	public float delay;
	public float sceneDelay;
	public string scene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	IEnumerator ExecuteAfterTime(float time) {
		yield return new WaitForSeconds(time);
		moodLight.SetActive(true);
		effect.Play();
		caption.transform.position = new Vector3(caption.transform.position.x, caption.transform.position.y, caption.transform.position.z - 0.2f);
	}
	
	IEnumerator LoadSceneAfterTime(float time) {
		yield return new WaitForSeconds(time);
		SceneManager.LoadScene(scene);
	}
	
	void OnTriggerEnter(Collider col) {
		StartCoroutine(ExecuteAfterTime(delay));
		StartCoroutine(LoadSceneAfterTime(sceneDelay));
	}
}
