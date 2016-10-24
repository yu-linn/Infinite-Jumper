using UnityEngine;
using System.Collections;

public class Jump2D : MonoBehaviour {
    public bool grounded;
    public float jumpHeight = 500f;
    public Transform groundcheck;
    float groundRadius = .05f;
    public LayerMask ground;



// Update is called once per frame
void FixedUpdate () {
        grounded = Physics2D.OverlapCircle(groundcheck.position,groundRadius,ground);
        if(grounded)

        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            //GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 0));
            //if (Input.GetKey(KeyCode.UpArrow)) {
               // GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight));
            //}
        }
        else
        {
            //GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -5f));
        }
        
	}

}
