using UnityEngine;
using System.Collections;

public class LookAtTheBadGui : MonoBehaviour {
	void Update() {
		GameObject[] gos;
		gos = GameObject.FindGameObjectsWithTag("Enemy");
		GameObject closest;
		float distance = 100;
		Vector3 position = transform.position;
		foreach (GameObject go in gos) {
			Vector3 diff = go.transform.position - position;
			float curDistance = diff.sqrMagnitude;
			if (curDistance < distance) {
				transform.LookAt(go.transform);
				Debug.Log("I'm looking at" + go);
			}
		}
	}
	public void Boom(){
		transform.localScale = new Vector3 (0.75f, 0.75f, 0.75f);
		Invoke ("UnBoom", 0.1f);
	}
	public void UnBoom(){
		transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
	}

}
