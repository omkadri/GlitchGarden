﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] int timeToWait = 4;
    int currentSceneIndex;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }
        IEnumerator WaitForTime()
        {
            yield return new WaitForSeconds(timeToWait);
            LoadNextScene(); 
        }

        public void LoadNextScene()
        {
            SceneManager.LoadScene(currentSceneIndex + 1); //because in build index, Loading screen is 0 and Start Screen is 1
        }

    }


