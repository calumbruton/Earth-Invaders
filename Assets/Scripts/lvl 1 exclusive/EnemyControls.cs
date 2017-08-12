using UnityEngine;
using System.Collections;

public class EnemyControls : MonoBehaviour {

	public float MoveSpeed;
	public bool MoveDown;
	public float timerSwitch;
	private float timer;

	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (MoveDown == true) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, MoveSpeed);
		} 
		else {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, - MoveSpeed);
		}
		//Changes movement direction every 3.5 seconds
		timer += Time.deltaTime;
		if(timer > timerSwitch){
			//translates the object to the left by one unit (0, -1) every time direction changes
			transform.Translate (Vector2.left);
			MoveDown = !MoveDown;
			timer = 0;
		}
	}

}
