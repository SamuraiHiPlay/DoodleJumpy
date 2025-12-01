using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("Scenes/Levels");
    }

    public void Pause()
    {
        Time.timeScale = 0;
        
    }
    
    public void QuitGame()
    {
        Console.WriteLine("Ти вийшов!");
        Application.Quit();
    }

    public void Settings()
    {
        SceneManager.LoadScene("Scenes/Setting");
    }

    public void Outfit()
    {
        SceneManager.LoadScene("Scenes/Outfit");
    }

    public void About(string LinkID)
    {
        Application.OpenURL(LinkID);
    }
}