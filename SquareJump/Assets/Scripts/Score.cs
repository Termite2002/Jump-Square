using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public int score;
    public int highscore;
    public TextMeshProUGUI scoreText, highScoreText;


    void Start()
    {
        highscore = PlayerPrefs.GetInt("Score");
        highScoreText.text = "Highscore: " + highscore.ToString();
    }
    void Update()
    {
        score = Mathf.RoundToInt(player.position.x - transform.position.x);
        scoreText.text = "Score: " + score.ToString();
    }

    public void End()
    {
        if (score > highscore)
        {
            highscore = score;
            highScoreText.text = "Highscore: " + highscore.ToString();
            PlayerPrefs.SetInt("Score", highscore);
            PlayerPrefs.Save();
        }
    }
}
