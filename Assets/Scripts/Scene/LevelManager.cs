using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scene
{
    public class LevelManager : MonoBehaviour
    {
        [SerializeField] 
        private int sceneIndex;
        
        private void Start()
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}