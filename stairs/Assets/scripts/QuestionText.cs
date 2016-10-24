using UnityEngine;
using System.Collections;

public class QuestionText : MonoBehaviour {
    public Font myFont;
	// Use this for initialization
	void Start () {
        //GUI.Label(new Rect(10, 5, 500, 20), "Which numbers are prime");
    }

    // Update is called once per frame
    void OnGUI()
    {
        string question = "";
        if (OnGUI2D.score < 100)
        {
            question = "Which numbers are odd?";
        }
        else if (OnGUI2D.score < 200 && OnGUI2D.score >= 100)

        {
            
               question = "Which numbers are divisible by 5?";
            
        }
        else if (OnGUI2D.score >= 200 && OnGUI2D.score < 300)
        {
            question = "Which numbers are divisible by 9?";
        }
        else if (OnGUI2D.score >= 300 && OnGUI2D.score < 400)
        {
            question = "Which numbers are multiples of 3?";
        }
        else if (OnGUI2D.score >= 400 && OnGUI2D.score < 500)
        {
            question = "Which numbers are multiples of 7?";
        }
        else if (OnGUI2D.score >= 500 && OnGUI2D.score < 600)
        {
            question = "Which numbers are perfect squares?";
        }
        else if (OnGUI2D.score >= 600 && OnGUI2D.score < 700)
        {
            question = "Which numbers have a ratio of 1:4?";
        }
        else if (OnGUI2D.score >= 700 && OnGUI2D.score < 800)
        {
            question = "Which decimal and fractions are equivalent?";
        }
        else if (OnGUI2D.score >= 800 && OnGUI2D.score < 900)
        {
            question = "Which numbers are prime?";
        }
        else if (OnGUI2D.score >= 900 && OnGUI2D.score < 1000)
        {
            question = "Which numbers are powers of 2?";
        }

        else if (OnGUI2D.score >= 1000)
        {
            question = "YOU'RE HOME :)";
        }

        var centeredStyle = GUI.skin.GetStyle("Label");
        centeredStyle.alignment = TextAnchor.UpperCenter;
        GUIStyle g = new GUIStyle();
        //Font myFont = (Font)Resources.Load("Pixel Font - Tripfive/Tripfive HS", typeof(Font));
        //myFont.fontSize = 40;
        g.font = myFont;
        g.fontSize = 40;
        g.normal.textColor = Color.white;
        
       
        GUI.Label(new Rect(10, 5, 500, 40), question);
    }
}
