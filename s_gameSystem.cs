using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class s_gameSystem : MonoBehaviour {

    public Text scoreText;
    public Text livestext;
    private int score;
    private int lives;


    public int kills;

	// Use this for initialization
	void Start ()
    {
        lives = 3;
        score = 0;
        scoreText.text = "Score: " + score.ToString();
        livestext.text = "Lives: " + lives.ToString();

    }

    // Update is called once per frame
    void Update ()
    {


        if (lives == 0)
        {
            SceneManager.LoadScene("DeathScreen");
            PlayerPrefs.SetInt("Score", score);
            PlayerPrefs.SetInt("KillCount", kills);
        }

        if (score < 0)
            score = 0;
	
	}

    public void UpdateScore(int newScore)
    {
        score += newScore;
        UpdateUI();
    }

   

    public void UpdateLives(int newLife)
    {
        lives += newLife;
        UpdateUI();
    }


    void UpdateUI()
    {
        scoreText.text = "Score: " + score.ToString();

        livestext.text = "Lives: " + lives.ToString();


    }

    public void sendStats()
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetInt("KillCount", kills);
    }
}
