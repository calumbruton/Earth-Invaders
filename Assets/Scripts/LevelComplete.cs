using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelComplete : MonoBehaviour {

	public Canvas nextLevel;
	private GameObject enemies;
	// Use this for initialization'

	void Start () {

		nextLevel = nextLevel.GetComponent<Canvas> ();
		nextLevel.enabled = false;
	}

	// Update is called once per frame
	void Update () {

		enemies = GameObject.FindWithTag("Enemy"); //find gameobjects with the tag "enemy" (you must therefore tag the enemies with "enemy"
		//if no gameobjects with the tag "enemy" are found -- THIS FINDS A SPECIFIC OBJECT WITH THE TAG MUST BE CHECKED EVERY FRAME because if initalized 
		//at the beginning it will only be following the first object found with that tag -- by doing this it will always check for an object with the tag until there are none left at all in the scene

		if(enemies == null){
			nextLevel.enabled = true;
		}
	}

	//This is a method that will be attached to a button in the inspector - loads the next level
	public void nextLevelButton()
	{
		Application.LoadLevel (Application.loadedLevel + 1);
	}
}