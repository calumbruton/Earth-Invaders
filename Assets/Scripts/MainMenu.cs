using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

	public Canvas quitMenu;
	public Button startText;
	public Button exitText;


	// Use this for initialization
	void Start () {

		//first line means that whatever is assigned to the quit menu variable in the inspector panel, we want you to go find the canvas component on that actual game object and assign it to the variable quitMenu
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
	}

	// Update is called once per frame
	void Update () {

	}


	public void ExitPress (){

		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;

	}

	public void noPress ()
	{
		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
	}

	public void startLevel ()
	{
		SceneManager.LoadScene (2);
	}

	public void exitGame ()
	{
		Application.Quit ();
	}



}