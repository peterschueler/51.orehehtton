using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
	public GameObject caption;
	public ParticleSystem effect;
	public GameObject light;
	public float delay;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	IEnumerator ExecuteAfterTime(float time) {
		yield return new WaitForSeconds(time);
		light.SetActive(true);
		effect.Play();
		caption.transform.position = new Vector3(caption.transform.position.x, caption.transform.position.y, caption.transform.position.z - 0.2f);
	}
	
	void OnTriggerEnter(Collider col) {
		StartCoroutine(ExecuteAfterTime(delay));
	}
}
