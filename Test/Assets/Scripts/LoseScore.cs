using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LoseScore : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;
    public Medal[] medals;
    public Image medalDisplay;

    public void PlayerLose ()
    {
        int score = ScoreManager.instance.score;
        scoreText.text = score.ToString();
        int bestScore = PlayerPrefs.GetInt("BestScore");
        if (score > bestScore)
            bestScore = score;
        for (int i = 0; i < medals.Length; i++)
        {
            if (medals[i].scoreNeed <= score)
            {
               medalDisplay.gameObject.SetActive(true);
               medalDisplay.sprite = medals[i].medalSprite;
            }
        }
        bestScoreText.text = bestScore.ToString();
        PlayerPrefs.SetInt("BestScore", bestScore);
    }
}
