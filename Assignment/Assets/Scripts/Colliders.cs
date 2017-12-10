using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliders : MonoBehaviour {

    private LevelManager myLevelManager;

	void OnCollisiOnEnter2D(Collision2D collision)
    {
        print("Collision with " + collision.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        print("Trigger by " + collider.gameObject.name);
        myLevelManager.LoadLevel("Win");
    }
        void Start ()
    {
        myLevelManager = GameObject.FindObjectOfType<LevelManager>();	
	}
	

}
