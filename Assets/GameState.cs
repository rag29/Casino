using UnityEngine;
using System.Collections;
//using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour {

	//the dice roll camera
	public GameObject cam1;

	//the view dice camera
	public GameObject cam2;

	//the game timer
	public static float timer;

	//roll timer
	public static float t1;

	//can the user select the dice they will keep
	public static bool selectDiceToKeep;

	//the collider that checks for which number has been rolled
	public GameObject checker;

	//keeps a count of the turn you are on
	public static int turn_count;

	//the canvas that has the roll dice button parented to it
	public Canvas canvas;

	//controls when to switch the cameras
	public static bool switch_cam;

	public static bool countUp;

	public static List<int> currentDiceHand;

	float score_timer;

	bool score_timer_count_up;

	// Use this for initialization
	void Start () 
	{
		//set the check camera to false at first
		cam2.SetActive (false);

		//set the checker to not active yet
		checker.SetActive (false);

		//the timer starts out at zero
		timer = 0f;

		//dont let the user choose which dice to keep yet
		selectDiceToKeep = false;

		//turn count starts at zero
		turn_count = 1;

		//canvas isn't enabled at first
		canvas.enabled = false;

		//camera switch is set to false at first
		switch_cam = false;

		t1 = 0f;

		currentDiceHand = new List<int>();

		score_timer = 0;

		score_timer_count_up = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		timer += Time.deltaTime;

		if (countUp) {
			t1 += Time.deltaTime;
		}

		if (score_timer_count_up) {
			score_timer += Time.deltaTime;
		}
		//state 3: select which dice to keep and choose when to re-roll the dice
		if (timer > 3.1f) {
			checker.SetActive (false);
			GetRidOfCols.disableCols = true;
			canvas.enabled = true;
		}

		//state 2: get the values of the dice that were rolled and show them to the user
		else if (timer > 3f) {
			//set the collider that determines the number rolled active
			checker.SetActive (true);

			//set the second camera active
			cam2.SetActive (true);

			//set the first camera not active
			cam1.SetActive (false);

			//allow the user to select the dice to keep
			selectDiceToKeep = true;

			//set the checker to active
			checker.SetActive (true);

			//don't disable the colliders: enable them
			GetRidOfCols.disableCols = false;
		}

		//state 1: roll the dice camera and stuff
		else if (switch_cam && timer < 3f) {
			//dont enable the canvas
			canvas.enabled = false;
			//put the roll dice camera up
			cam1.SetActive (true);
			//disable the other camera
			cam2.SetActive (false);
		}
			
		//end the current turn out of the thirteen total 
		if (turn_count == 3) {
			score_timer_count_up = true;
			//need to load the level where you can select your category
			canvas.enabled = false;
			if (score_timer > 10f) {
				SceneManager.LoadScene ("Scene2");
			}
		}


	}
}
