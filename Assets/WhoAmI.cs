using UnityEngine;
using System.Collections;

public class WhoAmI : MonoBehaviour {
	public string alphaname;
	public Rigidbody bullet;
	public Transform barrelEnd;
	public GameObject gun;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay (Collider col){
		if (col.name == "LetterReceiver") {
			if (Input.GetKeyDown(alphaname)){
				Debug.Log ("pewpew");
				Rigidbody bulletinstance;
				bulletinstance = Instantiate(bullet, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
				gun.BroadcastMessage("Boom");
				bulletinstance.AddForce(barrelEnd.forward * 1000);
				Destroy(gameObject);
			}
			}
				}
}

