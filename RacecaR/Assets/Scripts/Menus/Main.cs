using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Button startButton;
    public Button creditsButton;
    public Button quitButton;

    public Text instructionsKeyText;

	// Use this for initialization
	void Start ()
    {
        startButton.onClick.AddListener(onStart);
        creditsButton.onClick.AddListener(onCredits);
        quitButton.onClick.AddListener(onQuit);

        instructionsKeyText.text = "I | Instructions";
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.I))
            UIManager.instance.ChangeMenu(Menus.Instructions);
	}

    void onStart()
    {
        //UIManager.instance.ChangeMenu(Menus.StageSelection);
        GameManager.instance.StartGame();
    }

    void onCredits()
    {
        UIManager.instance.ChangeMenu(Menus.Credits);
    }

    void onQuit()
    {
        Application.Quit();
    }
}