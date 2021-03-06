﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour {
	public GameObject first;
	public GameObject second;
	public GameObject third;
	public GameObject fourth;

	// Use this for initialization
	void Start () {
		StartCoroutine(DisplayText(2, first));
		StartCoroutine(DisplayText(4, second));
		StartCoroutine(DisplayText(6, third));
		StartCoroutine(DisplayText(8, fourth));
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	IEnumerator DisplayText(float time, GameObject obj) {
		yield return new WaitForSeconds(time);
		obj.SetActive(true);
	}
}
