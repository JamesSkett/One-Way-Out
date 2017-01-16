using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class s_shootBullet : MonoBehaviour {

    public GameObject bullet;

    public Text ammoText;
    private int ammo;

    private AudioSource playerAudio;
    public AudioClip playerShoot;

	// Use this for initialization
	void Start ()
    {
        ammo = 5;
        ammoText.text = "Ammo: " + ammo.ToString();

        playerAudio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (ammo != 0)
        {
            if (Input.GetButtonDown("Shoot"))
            {
                Instantiate(bullet, transform.position, transform.rotation);
                playerAudio.PlayOneShot(playerShoot);

                UpdateAmmo(-1);
            }
        }

    }

    public void UpdateAmmo(int addAmmo)
    {
        ammo += addAmmo;
        UpdateAmmoText();
    }

    void UpdateAmmoText()
    {
        ammoText.text = "Ammo: " + ammo.ToString();
    }
}
