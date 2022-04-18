using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void LevelMenu()
    {
        SceneManager.LoadScene("Levels");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
