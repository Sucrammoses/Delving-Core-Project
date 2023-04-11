using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    [Header("UI Objects")]
    public TMP_Text scoreTextTMP;
    public GameObject GameOverTextObj;
    public GameObject RestartTextObj;

    private int score = 0;
    private bool gameover = false;
    private bool restart = false;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
      

    }

    // Update is called once per frame
    void Update()
    {
    
        // Restart Game by pressing the "R" Key
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Level1");

            }
            if (Input.GetKeyDown(KeyCode.Q))
            {

                Application.Quit();
                Debug.Log("EXITING GAME!");

            }


        }

    }


    public void AddtoScore(int scoreValuetoAdd)
    {
        score += scoreValuetoAdd;
        Debug.Log("Score: " + score);
        UpdateScoreText();

    }

    private void UpdateScoreText()
    {
        scoreTextTMP.text = "Score: " + score;
    }

    // Game Over&Prompt to Restart
    public void GameOver() // Method gets called by DestroybyContact.cs Script
    {
        gameover = true;
        GameOverTextObj.SetActive(true);

        restart = true;
        RestartTextObj.SetActive(true);
    }




}
