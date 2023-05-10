using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void EnterGame()

    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Continue(){
        Time.timeScale = 1;
        SceneManager.LoadScene(PauseMenu.thislevel);
        }
}
