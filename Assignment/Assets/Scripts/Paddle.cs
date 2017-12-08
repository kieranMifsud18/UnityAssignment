using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour{

    private Ball myBall;

    void Start()
    {
        myBall = GameObject.FindObjectOfType<Ball>();
    }

    void Update()
    {
        float mousePosInUnits = (Input.mousePosition.X / Screen.width * 13f) - 6.5;


        float mousePos = Mathf.Clamp(myBall.transform.position.y, 0);

        this.transform.position = paddlePostition;
    }
}
