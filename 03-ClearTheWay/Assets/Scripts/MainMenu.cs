﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void QuitGame()
    {
    	Debug.Log("Quit Game");
    	Application.Quit();
    }
}
