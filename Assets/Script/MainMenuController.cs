using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(1);
    }

    public void GameOver(){
        SceneManager.LoadScene(3);
    }

    public void HowToPlay(){
        SceneManager.LoadScene(2);
    }

    public void BackToMainMenu(){
        SceneManager.LoadScene(0);
    }

    public void QuitGame(){
        Application.Quit();
    }
}
