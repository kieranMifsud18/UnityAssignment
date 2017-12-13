using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private Rigidbody2D rd;
    public GameObject P1;
    public GameObject P2;
 
    
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        P1 = GameObject.Find("Player1");
        P2 = GameObject.Find("Player2");

        StartCoroutine(Pause());
    }


    void Update()
    {
        // if ball goes to far left
        if (transform.position.x < -16f)
        {
            //transform.position = Vector3.zero;
            //rd.velocity = Vector3.zero;

            //gives player 2 a point
            AddScore.instance.GivePlayerTwoAPoint();

            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
        }
        //if ball goes to far right
        if (transform.position.x > 16f)
        {
            //transform.position = Vector3.zero;
            //rd.velocity = Vector3.zero;

            //gives player 1 a point
            AddScore.instance.GivePlayerOneAPoint();
                 
            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
        }
    }

    IEnumerator Pause()
    {
        int directionX = Random.Range(-1, 2);
        int directionY = Random.Range(-1, 2);


        if (directionX == 0)
        {
            directionX = 1;
        }

        rd.velocity = new Vector2 (0f, 0f);
        yield return new WaitForSeconds(2);
        rd.velocity = new Vector2(7f * directionX, 7f * directionY);
    }
}

    