using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    class LevelInput : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F2))
            {
                SceneManager.LoadScene("Attractors");
            }
        }
    }
}
