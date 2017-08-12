using UnityEngine;
using System.Collections;

public class LaserShooter : MonoBehaviour {

	public Transform firePoint;
	public GameObject laser;
	private float timer;
	public float shotSpacing;
	private bool ready;




	// Use this for initialization
	void Start () {
	
		timer = shotSpacing;
		ready = true;
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;
		if (timer < shotSpacing) {
			ready = false;
		} 
		else {
			ready = true;
		}


		//Click L to shoot
		if(Input.GetKeyDown(KeyCode.L) && ready == true)
		{
			Instantiate (laser, firePoint.position, firePoint.rotation);
			timer = 0;
		}



}
}
