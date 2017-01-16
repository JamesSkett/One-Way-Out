using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class s_Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	}

    public void PlayGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void loadHelp()
    {
        SceneManager.LoadScene("HelpScreen");
    }

}
