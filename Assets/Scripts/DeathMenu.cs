using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public int sceneBuildIndex;
    public void RestartGame()
    {
        SceneManager.LoadScene(sceneBuildIndex);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
