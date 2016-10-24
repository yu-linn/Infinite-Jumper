using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class PlayerCollide : MonoBehaviour {
    public Collider FakePlatform;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //OnCollisionEnter(FakePlatform);
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "FakePlatform")
        {
            Lives.lives -= 1;
        }
        if (Lives.lives == 0)
        {
            //other.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
