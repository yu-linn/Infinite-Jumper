using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player" | Lives.lives == 0)
            {
                SceneManager.LoadScene(SceneManager.GetSceneAt(0).path);
            }
        }
    }
}
