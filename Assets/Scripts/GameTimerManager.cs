using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimerManager : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;

    private BackgroundManager backgroundManager;
    private AudioManager audioManager;

    public bool isGameOver = false;

    public GameObject menuGameOver;


    
    void Awake()
    {
        backgroundManager = GameObject.Find("BackgroundManager").GetComponent<BackgroundManager>();
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver == false)
        {
            currentTime = currentTime += Time.deltaTime;
            timerText.text = currentTime.ToString("0.0");
            TimeGameOver();
        }
    }

    public void TimeGameOver()
    {
        if(currentTime >= 90)
        {
            isGameOver = true;
            MenuGameOver();
        }
        if(currentTime >= 80)
        {
            timerText.color = Color.red;
        }
    }

    void MenuGameOver()
    {
        audioManager.GameOverSound();
        menuGameOver.SetActive(true);
        backgroundManager.StopBGM();
        Cursor.lockState = CursorLockMode.None;
    }
}
