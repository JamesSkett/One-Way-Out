using UnityEngine;
using System.Collections;

public class s_player : MonoBehaviour {

    private s_gameSystem gameSystem;
    private GameObject gameSystemGameObject;

    private AudioSource playerAudio;
    public AudioClip playerHurt;

    // Use this for initialization
    void Start ()
    {
        gameSystemGameObject = GameObject.FindGameObjectWithTag("MainCamera");
        gameSystem = gameSystemGameObject.GetComponent<s_gameSystem>();

        playerAudio = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update ()
    {
	    
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "enemyBullet")
        {
            Destroy(col.gameObject);
            gameSystem.UpdateScore(-100);
            gameSystem.UpdateLives(-1);

            playerAudio.PlayOneShot(playerHurt);


        }

        if (col.tag == "Enemy")
        {
            gameSystem.UpdateLives(-1);
            gameSystem.UpdateScore(-100);
        }


    }
}
