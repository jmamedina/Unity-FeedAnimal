using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    private float score;
    private float lives;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore(0);
        UpdateLives(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(float addScore)
    {
        score += addScore;
        scoreText.text = "Score :" + score;
    }

    public void UpdateLives(float decreaseLife)
    {
        lives += decreaseLife;
        livesText.text = "Lives :" + lives;
    }
}
