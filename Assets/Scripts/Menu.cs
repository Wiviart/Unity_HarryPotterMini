using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject startButton;
    public GameObject endPanel;
    void Start()
    {
        _PauseGame();
        endPanel.SetActive(false);
    }
    void Update()
    {
        if (FindObjectOfType<GameControl>().score < 0) _EndGame();
    }
    public void _PauseGame()
    {
        Time.timeScale = 0f;
        startButton.SetActive(true);
    }
    public void _StartGame()
    {
        Time.timeScale = 1f;
        startButton.SetActive(false);
    }
    public void _EndGame()
    {
        Time.timeScale = 0f;
        endPanel.SetActive(true);
    }
    public void _ResetGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
