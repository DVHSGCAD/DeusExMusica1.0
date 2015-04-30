using UnityEngine;
using System.Collections;

public class moveDown : MonoBehaviour {
	public float MoveSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.down * MoveSpeed * Time.deltaTime);
	}
}
