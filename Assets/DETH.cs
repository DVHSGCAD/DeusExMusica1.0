using UnityEngine;
using System.Collections;

public class DETH : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider col){
		if (col.tag == "BulletEnemy") {
			Destroy (gameObject, 0.1f);
				}
	}
}
