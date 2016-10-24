using UnityEngine;
using System.Collections;

public class Wrap2D : MonoBehaviour {

	// Use this for initialization
	void FixedUpdate()
    {
        if (transform.position.x <= -6f)
        {
            transform.position = new Vector3(6f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x >= 6f)
        {
            transform.position = new Vector3(-6f, transform.position.y, transform.position.z);

        }
    }
}
