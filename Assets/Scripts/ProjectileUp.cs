using UnityEngine;
using System.Collections;

public class ProjectileUp : MonoBehaviour {


	public float MoveSpeed;
	public GameObject enemyDeathEffect;
	public float enemyCounter;

	// Use this for initialization
	void Start () {

		enemyCounter = 0;
	}

	// Update is called once per frame
	void Update () {

		//Make this bitch move right
		GetComponent<Rigidbody2D>().AddForce(Vector2.up * MoveSpeed);
	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.tag == "Enemy"){
			Instantiate (enemyDeathEffect, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			Destroy (gameObject);
			enemyCounter += 1;

		}


	}

	//Destroy the projectile if it leaves camera view
	void OnBecameInvisible () {
		Destroy(gameObject);
	}
}
