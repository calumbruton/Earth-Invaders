using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {


	public Canvas gameDone;
	private GameObject player;

	// Use this for initialization
	void Start () {

		gameDone = gameDone.GetComponent<Canvas> ();
		gameDone.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		player = GameObject.FindWithTag ("Player");
		if (player == null) {
			gameDone.enabled = true;
		
		}
	}
		

	public void retryLevel (){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void mainMenu(){
		SceneManager.LoadScene (0);
	}
}
