using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class s_exit : MonoBehaviour {

    private s_gameSystem gameSystem;
    private GameObject gameSystemGameObject;

    // Use this for initialization
    void Start ()
    {
        gameSystemGameObject = GameObject.FindGameObjectWithTag("MainCamera");
        gameSystem = gameSystemGameObject.GetComponent<s_gameSystem>();

    }
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            gameSystem.sendStats();
            SceneManager.LoadScene("LevelEnd");
        }
    }
}
