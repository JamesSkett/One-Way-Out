using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class s_endGame : MonoBehaviour {

    public Text scoreText;
    public Text KillsText;
    public Text coinText;

    private int score;
    private int kills;
    private int coinCount;

	// Use this for initialization
	void Start ()
    {
        score = PlayerPrefs.GetInt("Score");
        kills = PlayerPrefs.GetInt("KillCount");
        coinCount = PlayerPrefs.GetInt("CoinCount");

        scoreText.text = "Score: " + score;
        KillsText.text = "Kills: " + kills;
        coinText.text = "Coins Collected: " + coinCount;

    }

    // Update is called once per frame
    void Update () {
	
	}
}
