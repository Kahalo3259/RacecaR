using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool isRunning;
    public bool isPaused;

    public Text timerText;
    float timer;

    public PlayerController player;
    public PlayerController player2;
    public float inverseDuration = 0;
    public float inverseCountdown;
    public bool inverseActive = false;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (isRunning && !isPaused)
        {
            timer = timer + 1 * Time.deltaTime;
            timerText.text = "" + timer;

            if (inverseActive)
            {
                inverseDuration -= 1 * Time.deltaTime;

                player.reverse = true;
                player2.reverse = true;

                if (inverseDuration <= 0)
                {
                    inverseCountdown = Random.Range(15f, 20f);
                    inverseActive = false;
                }
            }

            if (!inverseActive)
            {
                inverseCountdown -= 1 * Time.deltaTime;

                player.reverse = false;
                player2.reverse = false;

                if (inverseCountdown <= 0)
                {
                    inverseDuration = Random.Range(4f, 10f);
                    inverseActive = true;
                }
            }

            /*if (inverseCountdown <= 0)
            {
                resetDuration = true;

                if (resetDuration)
                {
                    inverseDuration = Random.Range(4f, 10f);
                    resetDuration = false;
                }
            }

            if (inverseDuration <= 0)
            {
                resetCountdown = true;

                if (resetCountdown)
                {
                    inverseCountdown = Random.Range(4f, 10f);
                    resetCountdown = false;
                }
            }*/
        }
    }

    public void StartGame()
    {
        isRunning = !isRunning;
        SceneManager.LoadScene("Level 1");
        //UIManager.instance.InstantiateMenus();

        initializeValues();
    }

    public void EndGame()
    {
        isRunning = !isRunning;
        isPaused = false;
        SceneManager.LoadScene("Main");
        //UIManager.instance.InstantiateMenus();
    }

    public void initializeValues()
    {
        inverseCountdown = Random.Range(20f, 25f);
        timerText = GameObject.Find("Timer").GetComponent<Text>();
    }
}