using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	public int starthealth;
	public int curhealth;
	// Use this for initialization
	void Start () {
		curhealth = starthealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (curhealth <= 0) {
			Destroy(gameObject, 0.1f);
				}
	}
	void OnTriggerEnter (Collider col)
	{
		if (col.tag == "BulletPlayer"){
			curhealth = curhealth -1;
		            }
	
	}
}
