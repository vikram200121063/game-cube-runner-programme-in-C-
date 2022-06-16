using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject TabToStart;
    public GameObject scoretext;
    // Start is called before the first frame update
    void Start()
    {
        GameOverPanel.SetActive(false);
        TabToStart.SetActive(true);
        scoretext.SetActive(false);
        PauseGame();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
        }
    }

    public void GameOver()
    {
        scoretext.SetActive(false);
        GameOverPanel.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        scoretext.SetActive(true);
        TabToStart.SetActive(false);
        
        Time.timeScale = 1f;
    }
}
