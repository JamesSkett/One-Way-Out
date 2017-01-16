using UnityEngine;
using System.Collections;

public class s_Pickup : MonoBehaviour {

    private s_gameSystem gameSystem;
    private GameObject gameSystemGameObject;

    private s_shootBullet shootBullet;
    private GameObject shootBulletGameObject;

    public GameObject door;

    private AudioSource pickupAudio;

    public AudioClip coinPickup;
    public AudioClip healthPickUp;
    public AudioClip ammoPickup;

    private int coinCount;

	// Use this for initialization
	void Start ()
    {
        gameSystemGameObject = GameObject.FindGameObjectWithTag("MainCamera");
        gameSystem = gameSystemGameObject.GetComponent<s_gameSystem>();

        shootBulletGameObject = GameObject.FindGameObjectWithTag("Shooter");
        shootBullet = shootBulletGameObject.GetComponent<s_shootBullet>();

        pickupAudio = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Coin")
        {
            Destroy(col.gameObject);
            gameSystem.UpdateScore(50);
            pickupAudio.PlayOneShot(coinPickup);
            coinCount++;
            PlayerPrefs.SetInt("CoinCount", coinCount);

        }

        if (col.tag == "Health")
        {
            Destroy(col.gameObject);
            gameSystem.UpdateLives(1);
            pickupAudio.PlayOneShot(healthPickUp);

        }

        if (col.tag == "Key")
        {
            Destroy(col.gameObject);
            door.SetActive(false);
        }
        
        if(col.tag == "Ammo")
        {
            Destroy(col.gameObject);
            shootBullet.UpdateAmmo(3);
            pickupAudio.PlayOneShot(ammoPickup);

        }
    }
}
