using UnityEngine;
using System.Collections;

public class Keel2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider col){
		if (col.tag == "EditorOnly") {
						Destroy (gameObject, 0.1f);
				}
	}
}
