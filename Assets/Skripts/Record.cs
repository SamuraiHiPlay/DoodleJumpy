using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour
{
    public Camera mainCam;
    public Text scoreText;
    public Text highScoreText;

    private float highestY;
    private int score;
    private int highScore;
    void Start()
    {
        if (mainCam == null)
        {
            mainCam = Camera.main;
        }
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        if (highScoreText)
        {
            highScoreText.text = "Рекорд: " + highScore;
        }
    }

    void Update()
    {
        if (transform.position.y > highestY)
        {
            highestY = transform.position.y;
            score = Mathf.FloorToInt(highestY * 10);
            if (scoreText)
            {
                scoreText.text = "Очки: " +  score;
            }

            if (score > highScore)
            {
                highScore =  score;
                PlayerPrefs.SetInt("HighScore", highScore);
                PlayerPrefs.Save();

                if (highScoreText)
                {
                    highScoreText.text = "Рекорд: " + highScore;
                }
            }
        }
    }
}
