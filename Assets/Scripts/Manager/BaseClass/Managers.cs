using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Manager
{
    public class Managers : MonoBehaviour
    {
        public static Managers Instance;

        protected virtual void Awake()
        {
            Instance = this;
        }

        public virtual void GotoScene(string scene)
        {
            SceneManager.LoadScene(scene);
        }
    }
}