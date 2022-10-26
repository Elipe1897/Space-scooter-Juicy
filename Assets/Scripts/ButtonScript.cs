using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void startbutton() //Function for a button - Leo N
    {
        SceneManager.LoadScene("LevelOne"); //Loads into the choosen scene, Game scene in this case - Leo N
    }
    void SettingsButton() //Function for a button - Leo N
    {
        SceneManager.LoadScene("Settings"); //Loads into the choosen scene, Settings scene in this case - Leo N
    }
    void ExitButton() //Function for a button - Leo N
    {
        Application.Quit(); //Exits the game when button is clicked - Leo N
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
