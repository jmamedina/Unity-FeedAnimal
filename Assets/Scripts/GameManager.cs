using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    private float score = 0;
    private float lives = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score :" + score;
        livesText.text = "Lives :" + lives;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {

    }

    public void UpdateLives()
    {

    }
}
