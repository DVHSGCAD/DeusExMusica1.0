using UnityEngine;
using System.Collections;

public class HomingMissle : MonoBehaviour {
	public Transform target;
	public float speed;
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player").transform;
		rb = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (target.position);

	}
}
