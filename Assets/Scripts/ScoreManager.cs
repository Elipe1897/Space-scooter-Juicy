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

    public int CurrentWave;
    public Text CurrentWaveText;

    public int Hearts;
    public Text HeartText;


    public void Awake()
    {
        instance = this; // it makes itself an instance
        CurrentWave = 1;
        Hearts = 3;
    }
    // Start is called before the first frame update
    public void Start()
    {
        // if the score points is higher than the highscore it replace the old highsore with the new highscore
        highscore = PlayerPrefs.GetInt("HIGHSCORE", 0);
        scoreText.text = "| POINTS: " + score.ToString() + " |  ";
        highscoreText.text = "| HIGHSCORE: " + highscore.ToString() + " | ";
        CurrentWaveText.text = "| Wave: " + CurrentWave.ToString() + " |";
        HeartText.text = "| Lives: " + Hearts.ToString() + " |";
    }
    // Update is called once per frame
    public void Update()
    {
        if(Hearts == 0)
        {
            Spaceship.instance.Death();
        }
        if (highscore < score) // Looks if score is higher than highscore 
        {
            PlayerPrefs.SetInt("HIGHSCORE", score);
        }
    }
    public void AddPoint(int point)// Adds the set points to points in score - Elias
    {
        score += point;
        scoreText.text = "| POINTS: " + score.ToString() + " |  ";
    }

    public void AddCurrentWave()
    {
        CurrentWave = 2;
        CurrentWaveText.text = "| Wave: " + CurrentWave.ToString() + " |";
    }
    public void AddCurrentWave3()
    {
        CurrentWave = 3;
        CurrentWaveText.text = "| Wave: " + CurrentWave.ToString() + " |";
    }
    public void AddCurrentWave4()
    {
        CurrentWave = 4;
        CurrentWaveText.text = "| Wave: " + CurrentWave.ToString() + " |";
    }
    public void AddCurrentWave5()
    {
        CurrentWave = 5;
        CurrentWaveText.text = "| Wave: " + CurrentWave.ToString() + " |";
    }

    public void RemoveLife()
    {
        Hearts--;
        HeartText.text = "| Lives: " + Hearts.ToString() + " |";
    }
}
//public void HighAddPoint() // Adds 15 points to score
//  {
// score += 20;
//   scoreText.text = score.ToString() + "POINTS";
// }
//  public void BossAddPoint() // Adds 50 points to score  
//  {
//     score += 50;
//     scoreText.text = score.ToString() + " POINTS";
//  }
//}
