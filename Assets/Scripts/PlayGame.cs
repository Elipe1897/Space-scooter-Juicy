using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
  public void StartGame()
    {
        SceneManager.LoadScene("SampleScene"); // loads the Samplescen where the game starts 
    }
}
/* i put some instuctions here start at the PlayScene and press the button the game starts and you get 10 points for the small monsters
  and for the big one you get 15 and for the boss you get 50 points. if you kill all monsters you win*/