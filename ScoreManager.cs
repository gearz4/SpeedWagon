using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    public TextMeshProUGUI currentScore;
    public int score = 0;
    public TextMeshProUGUI Highscore;
    public float Highscorecount;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        
    }

    // Update is called once per frame
    public void ChangeScore(int coinValue)   
    {
        score += coinValue;
        text.text = "X" + score.ToString();
    }

    void Update()
    {
        currentScore.text = score.ToString();
        /*if (score > Highscorecount)
        {
            Highscorecount = score;
            PlayerPrefs.SetFloat("X", Highscorecount);

        }
        Highscore.text = "X" + Mathf.Round(Highscorecount);*/
    }
}
