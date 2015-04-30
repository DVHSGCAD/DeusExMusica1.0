/*using UnityEngine;
using System.Collections;

public class Collide : MonoBehaviour {
	public GameObject collision;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay(Collider col){
		if (col.tag == "Key") {
			collision = col.gameObject;
			string key = collision.GetComponent<WhoAmI>();
			switch (key){
			case "A":
				if (Input.GetKeyDown("A"))
					Debug.Log("pewpew");
				break;
			default:
				break;
			}
				}
	}
}
**/