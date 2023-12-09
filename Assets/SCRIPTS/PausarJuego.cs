using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausarJuego : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool isPaused = false;

    void Start()
    {
         pauseMenu.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) 
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        pauseMenu.SetActive(true);
        isPaused = true;
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f; 
    }
}
