using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AddScore : MonoBehaviour {

    public static AddScore instance;

    public Text playerOneScoreText;
    public Text playerTwoScoreText;

    public static int playerOneScore;
    public static int playerTwoScore;
    public int MaxPoints = 3;
 
     
    void Start ()
    {

        instance = this;
    }
	
    void Update ()
    {
        if(playerOneScore >= MaxPoints || playerTwoScore >= MaxPoints)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
  
    public void GivePlayerOneAPoint()
    {
        playerOneScore += 1;
        playerOneScoreText.text = playerOneScore.ToString();
    }

    public void GivePlayerTwoAPoint()
    {
        playerTwoScore += 1;
        playerTwoScoreText.text = playerTwoScore.ToString();

    }
}
