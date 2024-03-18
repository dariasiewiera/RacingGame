using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int loop=0;
    public Text loopText;
    public GameObject gameOverScreen;
    public float bestTime;
    public Text BestTimeText;


    private void Start()
    {
           
    }

    public void addLoop()
    {
        loop++;
        loopText.text = loop.ToString();

        int minutes = Mathf.FloorToInt(bestTime / 60);
        int seconds = Mathf.FloorToInt(bestTime % 60);
        int milliseconds = Mathf.FloorToInt((bestTime * 1000) % 1000);
        string formattedTime = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);


        BestTimeText.text = formattedTime;
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

}
