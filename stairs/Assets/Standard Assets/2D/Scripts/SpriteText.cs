using UnityEngine;
using System.Collections;

public class SpriteText : MonoBehaviour
{
    public Transform whiteplatform;
    void Start()
    {
        
        var parent = transform.parent;

        var parentRenderer = parent.GetComponent<Renderer>();
        var renderer = GetComponent<Renderer>();
        renderer.sortingLayerID = parentRenderer.sortingLayerID;
        renderer.sortingOrder = parentRenderer.sortingOrder;

        var spriteTransform = parent.transform;
        var text = GetComponent<TextMesh>();
        var pos = spriteTransform.position;
        //float x = Random.Range(1f, 100f);
        if (whiteplatform.transform.position.y < 100)//(parent.transform.position.y < 100)
        {
            ArrayList odd = oddNumber(100);
            int i= (int)Random.Range(1f, odd.Capacity-1);
            text.text = string.Format("{0}", odd[i]);
        }
        else if (whiteplatform.transform.position.y < 200 && whiteplatform.transform.position.y >= 100)

        {

            ArrayList d5 = divisibleBy5(100);
            int i = (int)Random.Range(1f, d5.Capacity-1);
            text.text = string.Format("{0}", d5[i]);

        }
        else if (parent.transform.position.y >= 200 && parent.transform.position.y < 300)
        {
            ArrayList d = divisibleBy9(100);
            int i = (int)Random.Range(1f, d.Capacity-1);
            text.text = string.Format("{0}", d[i]);
        }
        else if (parent.transform.position.y >= 300 && parent.transform.position.y < 400)
        {

            ArrayList d = multipleOf7(200);
            int i = (int)Random.Range(1f, d.Capacity-1);
            text.text = string.Format("{0}", d[i]);
        }
        else if (parent.transform.position.y >= 400 && parent.transform.position.y < 500)
        {
            ArrayList d = multipleOf12(200);
            int i = (int)Random.Range(1f, d.Capacity-1);
            text.text = string.Format("{0}", d[i]);
        }
        else if (parent.transform.position.y >= 500 && parent.transform.position.y < 600)
        {
            ArrayList d = perfectSquares(12);
            int i = (int)Random.Range(1f, d.Capacity-1);
            text.text = string.Format("{0}", d[i]);
        }
        else if (parent.transform.position.y >= 600 && parent.transform.position.y < 700)
        {
            ArrayList d = ratio1To4(100);
            int i = (int)Random.Range(1f, d.Capacity-1);
            text.text = string.Format("{0}", d[i]);
        }
        else if (parent.transform.position.y >= 700 && parent.transform.position.y < 800)
        {
            ArrayList d = decimalFractionEq(10);
            int i = (int)Random.Range(1f, d.Capacity-1);
            text.text = string.Format("{0}", d[i]);
        }
        else if (parent.transform.position.y >= 800 && parent.transform.position.y < 900)
        {
            ArrayList p = primeNumbers(100);
            int x = (int)Random.Range(1f, p.Capacity-1);
            text.text = string.Format("{0}", p[x]);
        }
        else if (parent.transform.position.y >= 900 && parent.transform.position.y < 1000)
        {
            ArrayList d = powersOf2(10);
            int i = (int)Random.Range(1f, d.Capacity-1);
            text.text = string.Format("{0}", d[i]);
        }



    }
    public ArrayList oddNumber(int n)
    {
        ArrayList k = new ArrayList();
        for (int i= 0; i<n;i++)
        {
            if (i%2 == 1)
            {
                k.Add(i);
            }
        }
        return k;
    }
    public ArrayList divisibleBy5(int n)
    {
        ArrayList k = new ArrayList();
        for (int i = 0; i < n; i++)
        {
            if (i % 5 == 0)
            {
                k.Add(i);
            }
        }
        return k;
    }
    public ArrayList divisibleBy9(int n)
    {
        ArrayList k = new ArrayList();
        for (int i = 0; i < n; i++)
        {
            if (i % 9 == 0)
            {
                k.Add(i);
            }
        }
        return k;
    }
    public ArrayList multipleOf7(int n)
    {
        ArrayList k = new ArrayList();
        for (int i = 0; i < n; i++)
        {
            if (i % 7 == 0)
            {
                k.Add(i);
            }
        }
        return k;
    }
    public ArrayList multipleOf12(int n)
    {
        ArrayList k = new ArrayList();
        for (int i = 0; i < n; i++)
        {
            if (i % 12 == 0)
            {
                k.Add(i);
            }
        }
        return k;
    }
    public ArrayList perfectSquares(int n)
    {
        ArrayList k = new ArrayList();
        for (int i = 1; i < n; i++)
        {
            k.Add(i * i);
        }
        return k;
    }
    public ArrayList decimalFractionEq(int n)
    {
        ArrayList k = new ArrayList();
        for (int i = 1; i < n; i++)
        {
            for (int x= 1; x<n;x++)
            {
                double dec = i / x;
                k.Add(i + "/" + x + " = " + dec);
            }
        }
        return k;
    }
    public ArrayList powersOf2(int n)
    {
        ArrayList k = new ArrayList();
        for (int i = 0; i < n; i++)
        {
            Mathf.Pow(2, i);
        }
        return k;
    }
    public ArrayList ratio1To4(int n)
    {
        ArrayList k = new ArrayList();
        for (int i = 0; i < n; i++)
        {
            for (int x=1; x < n;x++)
            {
                if (1/4 == i/x)
                {
                    k.Add(i + ":" + x);
                }
            }
        }
        return k;
    }
    public ArrayList primeNumbers(int n)
    {
        ArrayList k = new ArrayList();

        
        for (int i =2; i<n;i++)
        {
            int prime = 0;
            for (int x=1;x<=i;x++)
            {
                if ((i % x) == 0)
                {
                    prime += 1;
                }
            }
            if (prime == 2)
            {
                k.Add(i);
            }
            
            
        }
        return k;
    }
}
