using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [SerializeField]
    public GameObject Background;
    public Text PauseMenuText;
    public Button PlayButton;
    public Button MainMenuButton;
    public Button RestartButton;
    public Canvas Canvas;
    public GameObject PauseMenu;





    // Start is called before the first frame update
    public void Start()
    {
        PauseMenu.SetActive(false);

    }
    public void startbutton() //Function for a button - Leo N
    {
        SceneManager.LoadScene("LevelOne"); //Loads into the choosen scene, Game scene in this case - Leo N
    }
   public void SettingsButton() //Function for a button - Leo N
    {
        SceneManager.LoadScene("Settings"); //Loads into the choosen scene, Settings scene in this case - Leo N
    }
    public void ExitButton() //Function for a button - Leo N
    {
        Application.Quit(); //Exits the game when button is clicked - Leo N
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
    }

    public void PlayGame()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
       

    }

    public void Restart()
    {

    }

    public void MainMenu()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
