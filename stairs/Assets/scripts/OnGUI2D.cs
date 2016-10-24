using UnityEngine;
using System.Collections;

public class OnGUI2D : MonoBehaviour
{
    public static float score;
    // Use this for initialization
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score: " + score);
    }
}
