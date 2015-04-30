using UnityEngine;
using System.Collections;

public class Glow : MonoBehaviour {
	public MeshRenderer Color;
	// Use this for initialization
	void Start () {
		Color = gameObject.GetComponent<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		//Color.material.color = Color.white;
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Key") {
			//Color.material.color = Color.red;
				}
	}
}
