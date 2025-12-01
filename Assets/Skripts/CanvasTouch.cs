using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CanvasTouch : MonoBehaviour
{
    public GameObject resetButton;
    
    public void ResetGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
