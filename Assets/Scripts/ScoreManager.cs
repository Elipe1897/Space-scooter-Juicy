using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text highscoreText;
    // varibles for the score and highscore
    public int score = 0;
    int highscore = 0;
  
    
    public void Awake()
    {
        instance = this; // it makes itself an instance
    }
    // Start is called before the first frame update
    public void Start()
    {
        // if the score points is higher than the highscore it replace the old highsore with the new highscore
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " POINTS";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }
    // Update is called once per frame
    public void Update()
    {
        if (highscore < score) // Looks if score is higher than highscore 
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }
    public void AddPoint()// Adds 10 points to score
    {
        score += 10;
        scoreText.text = score.ToString() + " POINTS";
    }
    public void HighAddPoint() // Adds 15 points to score
    {
        score += 15;
        scoreText.text = score.ToString() + "POINTS";
    }
        public void BossAddPoint() // Adds 50 points to score  
        {
           score += 50;
           scoreText.text = score.ToString() + " POINTS";
        }
}
