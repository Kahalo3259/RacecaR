using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public Button returnButton;
    public Button quitButton;

    public Text instructionsKeyText;

	// Use this for initialization
	void Start ()
    {
        returnButton.onClick.AddListener(onReturn);
        quitButton.onClick.AddListener(onQuit);

        instructionsKeyText.text = "I | Instructions";
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.I))
            UIManager.instance.ChangeMenu(Menus.Instructions);
	}

    void onReturn()
    {
        GameManager.instance.EndGame();
    }

    void onQuit()
    {
        Application.Quit();
    }
}
