using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    public Button level1_button, level2_button, level3_button, level4_button, level5_button, level6_button;

    public static bool level1, level2, level3, level4, level5, level6;
    private void Start()
    {
        level1 = true; 
    }
    public void startlevel1()
    {
        LevelManager.level1 = true;
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
    }
    public void startlevel2()
    {
        LevelManager.level1 = true;
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1;
    }
    public void startlevel3()
    {
        LevelManager.level1 = true;
        SceneManager.LoadScene("Level3");
        Time.timeScale = 1;

    }
    public void startlevel4()
    {
        LevelManager.level1 = true;
        SceneManager.LoadScene("Level4");
        Time.timeScale = 1;
    }
    public void startlevel5()
    {
        LevelManager.level1 = true;
        SceneManager.LoadScene("Level5");
        Time.timeScale = 1;
    }
    public void startlevel6()
    {
        LevelManager.level1 = true;
        SceneManager.LoadScene("Level6");
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (level1 == true)
        {
            level1_button.interactable = true;

            
        }

        if (level2==true)
        {
            level2_button.interactable = true;
            
        }

        if (level3 == true)
        {
            level3_button.interactable = true;
            
        }

        if (level4 == true)
        {
            level4_button.interactable = true;
            
        }

        if (level5 == true)
        {
            level5_button.interactable = true;
            
        }

        if (level6 == true)
        {
            level6_button.interactable = true;
            
        }    
    }
}
