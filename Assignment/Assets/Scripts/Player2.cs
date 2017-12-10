using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {

    private float Speed;
    private Rigidbody2D rd;
    private float boundY = 3.7f;

    void Start()
    {
        Speed = 3;
        rd = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float axisX = Input.GetAxis("Vertical");
        float axisY = Input.GetAxis("Horizontal");

        transform.Translate(new Vector2(axisY, axisX));

        var pos = transform.position;
        if(pos.y > boundY)
        {
            pos.y = boundY;
        }
        transform.position = pos;
    }
}