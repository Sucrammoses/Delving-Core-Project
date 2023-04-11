using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

/**Source: Youtube by Coco Code 
 * 
 * https://www.youtube.com/watch?v=YUcvy9PHeXs
 * NOT ADDED YET TO SCENE AND ONLY JUST ADDED TO ASSETS.SCRIPTS
 * Note this is a place holder for score points and highest score
 * * Added to Comp391 Group Project Assets by Jonathan Bonda 301288990 20230313
 * **/


public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    public Text scoreText;
    // public Text highScoreText;

    [Header("UI Objects")]
    public TMP_Text scoreTextTMP;
    public TMP_Text healthTextTMP;

    public float currentHealth = 100;
    public float maxHealth = 100;
    
        
    int score = 0;
    
    // int highScore = 0;

    private void Awake()
    {
        instance = this;

    }

    // Start is called before the first frame update
    void Start()
    {

        // scoreText.text = score.ToString() + " POINTS";
        UpdateScoreText();
        UpdatePlayerGlobalHealth();

    }



    public void AddPoint(int pointValue)
    {
        score = score + pointValue;
        scoreTextTMP.text = score.ToString();
        Debug.Log("Score: " + score);
        UpdateScoreText();

    }

    public void PlayerTakeDamage(int damagePoint)
    {
        currentHealth = currentHealth - damagePoint;
        healthTextTMP.text = currentHealth.ToString();
        Debug.Log("Health Points: " + currentHealth);
    }

    private void UpdateScoreText()
    {
        
        scoreTextTMP.text = "Score: " + score;
    }

    private void UpdatePlayerGlobalHealth()
    {
        healthTextTMP.text = "Health Points: " + currentHealth;
                
    }
}
