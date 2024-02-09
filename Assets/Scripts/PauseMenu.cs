using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject player;
    private FPS playerFPS;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerFPS = player.GetComponent<FPS>();
    }
    public void ResumeGame()
    {
        playerFPS.ResumeGame();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
