using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;

public class UI_ScoreCategory_Script : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {

	Text thisCategory;
	Color defaultColor;
	Animator anim;
	List<int> dice;

	int total_category_score;

	int total_score_overall;

	int one_count;
	int two_count;
	int three_count;
	int four_count;
	int five_count;
	int six_count;

	// Use this for initialization
	void Start () 
	{
		thisCategory = gameObject.GetComponent<Text> ();
		defaultColor = thisCategory.GetComponent<Text> ().color;
		anim = this.GetComponent<Animator> ();
		dice = new List<int>();

		dice.Add (0); dice.Add (0); dice.Add (0); dice.Add (0); dice.Add (0);

		GameState.currentDiceHand [10] = 1;
		GameState.currentDiceHand [11] = 2;
		GameState.currentDiceHand [12] = 3;
		GameState.currentDiceHand [13] = 4;
		GameState.currentDiceHand [14] = 2;

		dice [0] = GameState.currentDiceHand [10];
		dice [1] = GameState.currentDiceHand [11];
		dice [2] = GameState.currentDiceHand [12];
		dice [3] = GameState.currentDiceHand [13];
		dice [4] = GameState.currentDiceHand [14];

		total_category_score = 0;
		total_score_overall = 0;

		one_count = 0;
		two_count = 0;
		three_count = 0;
		four_count = 0;
		five_count = 0;
		six_count = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void OnPointerEnter(PointerEventData dataName)
	{
		
		switch (this.gameObject.tag) 
		{
		case "ones":
			anim.SetTrigger ("shouldAnimate");
			break;
		case "twos":
			anim.SetTrigger ("shouldAnimate");
			break;
		case "threes":
			anim.SetTrigger ("shouldAnimate");
			break;
		case "fours":
			anim.SetTrigger ("shouldAnimate");
			break;
		case "fives":
			anim.SetTrigger ("shouldAnimate");
			break;
		case "sixes":
			anim.SetTrigger ("shouldAnimate");
			break;
		case "3kind":
			anim.SetTrigger ("shouldAnimate");
			break;
		case "4kind":
			anim.SetTrigger ("shouldAnimate");
			break;
		case "fullhouse":
			anim.SetTrigger ("shouldAnimate");
			break;
		case "smst":
			anim.SetTrigger ("shouldAnimate");
			break;
		case "lgst":
			anim.SetTrigger ("shouldAnimate");
			break;
		case "chance":
			anim.SetTrigger ("shouldAnimate");
			break;
		case "yahtzee":
			anim.SetTrigger ("shouldAnimate");
			break;
		}
	}

	public void OnPointerClick(PointerEventData dataName)
	{
		switch (this.gameObject.tag) 
		{
		    //----------------------------------------------------------------------------------ONES--------------------------------------------------------------------------------------------------------------------------------------------------------------
		case "ones":
			foreach (int i in dice) {
				if (i == 1) {
					total_category_score += 1;
				}
			}
			//add the total category score to the totall overall score
			total_score_overall += total_category_score;
			print (total_category_score);
			break;
			//----------------------------------------------------------------------------------TWOS--------------------------------------------------------------------------------------------------------------------------------------------------------------
		case "twos":
			foreach (int i in dice) {
				if (i == 2) 
				{
					total_category_score += 2;
				}
			}
			//add the total category score to the totall overall score
			total_score_overall += total_category_score;
			print (total_category_score);
			break;
			//----------------------------------------------------------------------------------THREES--------------------------------------------------------------------------------------------------------------------------------------------------------------
		case "threes":
			foreach (int i in dice) {
				if (i == 3) 
				{
					total_category_score += 3;
				}
			}
			//add the total category score to the totall overall score
			total_score_overall += total_category_score;
			print (total_category_score);
			break;
			//----------------------------------------------------------------------------------FOURS--------------------------------------------------------------------------------------------------------------------------------------------------------------
		case "fours":
			foreach (int i in dice) {
				if (i == 4) 
				{
					total_category_score += 4;
				}
			}
			//add the total category score to the totall overall score
			total_score_overall += total_category_score;
			print (total_category_score);
			break;
			//----------------------------------------------------------------------------------FIVES--------------------------------------------------------------------------------------------------------------------------------------------------------------
		case "fives":
			foreach (int i in dice) {
				if (i == 5) 
				{
					total_category_score += 5;
				}
			}
			//add the total category score to the totall overall score
			total_score_overall += total_category_score;
			print (total_category_score);
			break;
			//----------------------------------------------------------------------------------SIXES--------------------------------------------------------------------------------------------------------------------------------------------------------------
		case "sixes":
			foreach (int i in dice) {
				if (i == 6) 
				{
					total_category_score += 6;
				}
			}
			//add the total category score to the totall overall score
			total_score_overall += total_category_score;
			print (total_category_score);
			break;
			//----------------------------------------------------------------------------------3 OF A KIND--------------------------------------------------------------------------------------------------------------------------------------------------------------
		case "3kind":
			foreach (int i in dice) {
				switch (i) {
				case 1:
					one_count += 1;
					break;
				case 2:
					two_count += 1;
					break;
				case 3:
					three_count += 1;
					break;
				case 4:
					four_count += 1;
					break;
				case 5:
					five_count += 1;
					break;
				case 6:
					six_count += 1;
					break;
				}
			}

			if (one_count >= 3 || two_count >= 3 || three_count >= 3 || four_count >= 3 || five_count >= 3 || six_count >= 3) {
				foreach (int i in dice) {
					total_category_score += i;
				}
			}
			//add the total category score to the totall overall score

			one_count = 0;
			two_count = 0;
			three_count = 0;
			four_count = 0;
			five_count = 0;

			total_score_overall += total_category_score;
			print (total_category_score);
			break;
			//----------------------------------------------------------------------------------4 OF A KIND--------------------------------------------------------------------------------------------------------------------------------------------------------------
		case "4kind":
			foreach (int i in dice) {
				switch (i) {
				case 1:
					one_count += 1;
					break;
				case 2:
					two_count += 1;
					break;
				case 3:
					three_count += 1;
					break;
				case 4:
					four_count += 1;
					break;
				case 5:
					five_count += 1;
					break;
				case 6:
					six_count += 1;
					break;
				}
			}

			if (one_count >= 4 || two_count >= 4 || three_count >= 4 || four_count >= 4 || five_count >= 4 || six_count >= 4) {
				foreach (int i in dice) {
					total_category_score += i;
				}
			}
			//add the total category score to the totall overall score

			one_count = 0;
			two_count = 0;
			three_count = 0;
			four_count = 0;
			five_count = 0;

			total_score_overall += total_category_score;
			print (total_category_score);
			break;
			//----------------------------------------------------------------------------------FULL HOUSE--------------------------------------------------------------------------------------------------------------------------------------------------------------
		case "fullhouse":
			
			List<int> countList = new List<int> ();

			countList.Add (0); 
			countList.Add (0); 
			countList.Add (0); 
			countList.Add (0); 
			countList.Add (0);

			bool three_of_something = false;
			bool two_of_something = false;

			foreach (int i in dice) {
				switch (i) {
				case 1:
					one_count += 1;
					break;
				case 2:
					two_count += 1;
					break;
				case 3:
					three_count += 1;
					break;
				case 4:
					four_count += 1;
					break;
				case 5:
					five_count += 1;
					break;
				case 6:
					six_count += 1;
					break;
				}
			}
			countList [0] = one_count;
			countList [1] = two_count;
			countList [2] = three_count;
			countList [3] = four_count;
			countList [4] = five_count;

			foreach (int i in countList) {
				if (i == 3) {
					three_of_something = true;
				} else if (i == 2) {
					two_of_something = true;
				}
			}

			if (three_of_something && two_of_something)
			{
				
				total_category_score += 25;

			}

			one_count = 0;
			two_count = 0;
			three_count = 0;
			four_count = 0;
			five_count = 0;

			total_score_overall += total_category_score;
			print (total_category_score);
			break;

			//----------------------------------------------------------------------------------SMALL STRAIGHT--------------------------------------------------------------------------------------------------------------------------------------------------------------
		case "smst":

			foreach (int i in dice) {
				switch (i) {
				case 1:
					one_count += 1;
					break;
				case 2:
					two_count += 1;
					break;
				case 3:
					three_count += 1;
					break;
				case 4:
					four_count += 1;
					break;
				case 5:
					five_count += 1;
					break;
				case 6:
					six_count += 1;
					break;
				}
			}

			if ((one_count >= 1 && two_count >= 1 && three_count >= 1 && four_count >= 1) || (two_count >= 1 && three_count >= 1 && four_count >= 1 && five_count >= 1) || (three_count >= 1 && four_count >= 1 && five_count >= 1 && six_count >= 1)) 
			{
				total_category_score += 30;
			}

			one_count = 0;
			two_count = 0;
			three_count = 0;
			four_count = 0;
			five_count = 0;

			total_score_overall += total_category_score;
			print (total_category_score);
			break;
			//----------------------------------------------------------------------------------LARGE STRAIGHT--------------------------------------------------------------------------------------------------------------------------------------------------------------
		case "lgst":

			foreach (int i in dice) {
				switch (i) {
				case 1:
					one_count += 1;
					break;
				case 2:
					two_count += 1;
					break;
				case 3:
					three_count += 1;
					break;
				case 4:
					four_count += 1;
					break;
				case 5:
					five_count += 1;
					break;
				case 6:
					six_count += 1;
					break;
				}
			}



			one_count = 0;
			two_count = 0;
			three_count = 0;
			four_count = 0;
			five_count = 0;

			total_score_overall += total_category_score;
			print (total_category_score);
			break;
			//----------------------------------------------------------------------------------CHANCE--------------------------------------------------------------------------------------------------------------------------------------------------------------
		case "chance":
			foreach (int i in dice) {
				total_category_score += i;
			}
			//add the total category score to the totall overall score
			total_score_overall += total_category_score;
			print (total_category_score);
			break;
			//----------------------------------------------------------------------------------YAHTZEE--------------------------------------------------------------------------------------------------------------------------------------------------------------
		case "yahtzee":
			
			break;
		}
	}

	public void OnPointerExit(PointerEventData dataName)
	{
		switch (this.gameObject.tag) 
		{
		case "ones":
			anim.ResetTrigger ("shouldAnimate");
			break;
		case "twos":
			anim.ResetTrigger ("shouldAnimate");
			break;
		case "threes":
			anim.ResetTrigger ("shouldAnimate");
			break;
		case "fours":
			anim.ResetTrigger ("shouldAnimate");
			break;
		case "fives":
			anim.ResetTrigger ("shouldAnimate");
			break;
		case "sixes":
			anim.ResetTrigger ("shouldAnimate");
			break;
		case "3kind":
			anim.ResetTrigger ("shouldAnimate");
			break;
		case "4kind":
			anim.ResetTrigger ("shouldAnimate");
			break;
		case "fullhouse":
			anim.ResetTrigger ("shouldAnimate");
			break;
		case "smst":
			anim.ResetTrigger ("shouldAnimate");
			break;
		case "lgst":
			anim.ResetTrigger ("shouldAnimate");
			break;
		case "chance":
			anim.ResetTrigger ("shouldAnimate");
			break;
		case "yahtzee":
			anim.ResetTrigger ("shouldAnimate");
			break;
		}
	}
}
