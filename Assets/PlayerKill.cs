using UnityEngine;
using System.Collections;

public class PlayerKill : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider col){
		switch (col.tag) {
		case "Key":
			Destroy (gameObject);
			break;
		case "Player":
			Destroy (gameObject, 0.1f);
			break;
		default:
			break;
		}
	}
}
