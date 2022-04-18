using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishManager : MonoBehaviour
{
    
    public void finishlevel1()
    {
        LevelManager.level2 = true;
        SceneManager.LoadScene("Levels");
    }
    public void finishlevel2()
    {
        LevelManager.level3 = true;
        SceneManager.LoadScene("Levels");
    }
    public void finishlevel3()
    {
        LevelManager.level4 = true;
        SceneManager.LoadScene("Levels");
    }
    public void finishlevel4()
    {
        LevelManager.level5 = true;
        SceneManager.LoadScene("Levels");
    }
    public void finishlevel5()
    {
        LevelManager.level6 = true;
        SceneManager.LoadScene("Levels");
    }
    public void finishlevel6()
    {
        SceneManager.LoadScene("Levels");
    }
}
