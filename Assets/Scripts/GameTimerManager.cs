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

    public bool isGameOver = false;

    public GameObject menuGameOver;


    // Start is called before the first frame update
    void Start()
    {
        
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
        menuGameOver.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
}
