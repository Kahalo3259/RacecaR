﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapSystem : MonoBehaviour {

    public int lapCount;
    public Text text;
    public PlayerController player;

	// Use this for initialization
	void Start () {
        text = gameObject.GetComponent<Text>();
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }
	
	// Update is called once per frame
	void Update () {
        lapCount = player.lap/2 ;

        text.text = "" + lapCount;
	}
}
