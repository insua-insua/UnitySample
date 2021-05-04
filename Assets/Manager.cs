using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int score;

    static public Manager instance;
    private void Awake()
    {
        instance = this;
    }

    public TextMeshProUGUI scoreText;
    public void AddScore(int addPoint)
    {
        score += addPoint;

        scoreText.text = score.ToString();
    }
        
}
