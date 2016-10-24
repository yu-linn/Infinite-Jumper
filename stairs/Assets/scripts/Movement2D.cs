using UnityEngine;
using System.Collections;

public class Movement2D : MonoBehaviour {
    public float moveSpeed = 4f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(h * moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
	}
}
