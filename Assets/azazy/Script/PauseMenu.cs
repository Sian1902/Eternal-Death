using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static int thislevel;
    [SerializeField] GameObject activepause, inactivepause;
    public void pause()
    {
        inactivepause.SetActive(false);
        Time.timeScale = 0f;
        activepause.SetActive(true);
    }
    public void resume()
    {
        activepause.SetActive(false);
        Time.timeScale = 1f;
        inactivepause.SetActive(true);
    }
    public void home()
    {
        thislevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("MainMenu");
    }
    public void retry()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1.0f;
    }
    public void skip()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
