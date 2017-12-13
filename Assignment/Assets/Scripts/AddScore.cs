using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AddScore : MonoBehaviour {

    public static AddScore instance;

    public Text playerOneScoreText;
    public Text playerTwoScoreText;

    public int playerOneScore;
    public int playerTwoScore;
     
    void Start ()
    {

        instance = this;

        playerOneScore = playerTwoScore = 0;
        

    }
	
	
	void Update () {
		
	}

    public void GivePlayerOneAPoint()
    {
        playerOneScore += 1;
        playerOneScoreText.text = playerOneScore.ToString();

        //enter player 1 wins level1
        if (playerOneScore > 2)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void GivePlayerTwoAPoint()
    {
        playerTwoScore += 1;
        playerTwoScoreText.text = playerTwoScore.ToString();

        //enter player 2 wins level1
        if (playerTwoScore > 2)
        {
           SceneManager.LoadScene(2);
        }
    }
}
