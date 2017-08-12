using UnityEngine;
using System.Collections;

public class EndZoneScript : MonoBehaviour {

	private GameObject Matt;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Enemy"){
			Matt = (GameObject.FindWithTag("Player"));
			Destroy (Matt);
		}
	}
}
