using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	public GameObject target;
	public Rigidbody bullet;
	public Transform barrelend;
	public float bulletspeed;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("PewPew", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		target = GameObject.FindGameObjectWithTag ("Player");
		transform.LookAt (target.transform);
	}
	void PewPew (){
		Rigidbody rocketInstance;
		rocketInstance = Instantiate(bullet, barrelend.position, barrelend.rotation) as Rigidbody;
		rocketInstance.AddForce(barrelend.forward * bulletspeed);
		}
}
