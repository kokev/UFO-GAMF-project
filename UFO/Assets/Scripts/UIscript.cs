using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIscript : MonoBehaviour {

    public Text scoreText;
    public Text highScoreText;
    public GameObject player;

    public int score;
    public int highScore;

	// Use this for initialization
	void Start () {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = highScore.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        ScoreCounter();
    }

    
    public void ScoreCounter()
    {
        float kurvaAnyad = Mathf.Round(((player.transform.position.y) * 0.2F));
        score = Mathf.RoundToInt(kurvaAnyad);
        scoreText.text = score.ToString();
    }

    public void HighScore()
    {
    
        if (score > PlayerPrefs.GetInt("HighScore"))
        {
             PlayerPrefs.SetInt("HighScore", score);
             highScore = PlayerPrefs.GetInt("HighScore");
             highScoreText.text = highScore.ToString();
        }

    }
 
}
