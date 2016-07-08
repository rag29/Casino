using UnityEngine;
using System.Collections;

public class ButtonClicked : MonoBehaviour {

	public GameObject cam1;
	public GameObject cam2;

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void WhatToDoWhenClicked()
	{
		GameState.turn_count += 1;

		GameState.timer = 0f;

		GameState.t1 = 0f;

		GameState.switch_cam = true;

		GameState.countUp = true;
		//RollDice_Animations1.playIt = true;
		//RollDice_Animations2.playIt = true;
		//RollDice_Animations3.playIt = true;
		//RollDice_Animations4.playIt = true;
		//RollDice_Animations5.playIt = true;

	}
}
