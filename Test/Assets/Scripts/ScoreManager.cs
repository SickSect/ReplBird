using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI    scoreText;
    private TextMeshProUGUI                     text;
    public int                                  score { get; set; }
    public static ScoreManager                  instance { get; set;}

    private void Start()
    {
        instance = this;
        SetScore(0);
    }

    public void SetScore(int score)
    {
        this.score += score;
        scoreText.text = this.score.ToString();
    }
}
