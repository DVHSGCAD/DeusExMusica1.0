﻿using UnityEngine;
using System.Collections;

public class Keel3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider col){
		Destroy (col.gameObject);
	}
}
