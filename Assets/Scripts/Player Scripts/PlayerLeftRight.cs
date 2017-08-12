using UnityEngine;
using System.Collections;

public class PlayerLeftRight : MonoBehaviour {

	public float movementSpeed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (movementSpeed * Time.deltaTime, 0, 0);
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.position -= new Vector3 (movementSpeed * Time.deltaTime, 0, 0);
		}
	}
}
