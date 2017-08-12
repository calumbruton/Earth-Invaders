using UnityEngine;
using System.Collections;

public class holddownshoot : MonoBehaviour {

	public Transform firePoint;
	public GameObject ammo;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//HOLD or ClICK L to shoot - GETKEY continues to fire while L is held down - GETKEYDOWN only does it the first frame L is held down
		if(Input.GetKey(KeyCode.L)){ 
			Instantiate (ammo, firePoint.position, firePoint.rotation);
		}

	}
			
}
