using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public Text creditsText;

    public Button returnButton;

	// Use this for initialization
	void Start ()
    {
        creditsText.text = 
            "Renso Hernandez - Programmer/Menu System\n" +
            "";

        returnButton.onClick.AddListener(onReturn);
	}
	
	void onReturn()
    {
        UIManager.instance.ChangeMenu(Menus.Main);
    }
}
