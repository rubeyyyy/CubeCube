﻿
using UnityEngine;
using UnityEngine.SceneManagement;

public class menue : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
