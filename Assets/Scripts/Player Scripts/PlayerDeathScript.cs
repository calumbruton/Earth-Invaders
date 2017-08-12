using UnityEngine;
using System.Collections;

public class PlayerDeathScript : MonoBehaviour {

	public GameObject enemyDeathEffect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//void OnCollisionEnter2D(Collision2D other) {
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Enemy") {
			Instantiate (enemyDeathEffect, other.transform.position, other.transform.rotation);
			Destroy (gameObject);
		}
	}
}