using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {
    public static float lives;
	// Use this for initialization
	void Start () {
        lives = 10;
	}

    // Update is called once per frame
    void OnGUI()
    {
        GUI.skin.label.alignment = TextAnchor.UpperRight;
        GUI.Label(new Rect(350, 10, 100, 20), "Lives: " + lives);
    }
}
