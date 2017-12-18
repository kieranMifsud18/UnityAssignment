using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AddScoreLv3 : MonoBehaviour {

    public static AddScoreLv3 instance;

    public Text playerOneScoreText;
    public Text playerTwoScoreText;

    public int playerOneScore;
    public int playerTwoScore;
    public int MaxPoints = 3;


    void Start()
    {
        instance = this;

        
    }


    public void GivePlayerOneAPoint()
    {
        playerOneScore += 1;
        playerOneScoreText.text = playerOneScore.ToString();

        //enter player 1 wins
        if (playerOneScore >= MaxPoints)
        {
         SceneManager.LoadScene(4);
         }
    }

    public void GivePlayerTwoAPoint()
    {
        playerTwoScore += 1;
        playerTwoScoreText.text = playerTwoScore.ToString();

        //enter player 2 wins
        if (playerTwoScore >= MaxPoints)
        {
           SceneManager.LoadScene(5);
        }
    }
}
