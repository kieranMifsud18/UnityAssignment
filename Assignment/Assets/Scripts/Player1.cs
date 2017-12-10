using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    private float Speed;
    private Rigidbody2D rd;
    private float boundY = 3.7f;

    void Start ()
    {
        Speed = 5;
        rd = this.GetComponent<Rigidbody2D>();
    }

    void Update ()
    {
        float mousePosInUnits = (Input.mousePosition.y / Screen.height * 10f) - 6.5f;

        Vector3 paddlePosition = new Vector3(-5.88f, mousePosInUnits, this.transform.position.x);
        this.transform.position = paddlePosition;

        var pos = transform.position;
        if(pos.y > boundY)
        {
            pos.y = boundY;
        }

        else if(pos.y <- boundY)
        {
            pos.y = -boundY;
        }
        transform.position = pos;
    }
   
}