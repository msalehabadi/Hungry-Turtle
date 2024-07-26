using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RTLTMPro;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;

    private void OnEnable()
    {
        int score = PlayerPrefs.GetInt("امتیاز"+ SceneManager.GetActiveScene().name,0);
        scoreText.text = "امتیاز: "+ score.ToString();

        int highScore = PlayerPrefs.GetInt("بیشترین امتیاز"+ SceneManager.GetActiveScene().name,0);
        highScoreText.text = "بیشترین امتیاز: "+ highScore.ToString();
    }
}
