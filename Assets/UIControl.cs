using UnityEngine;
using System.Collections;

public class UIControl : MonoBehaviour {

	public GameObject[] die1_images;
	public GameObject[] die2_images;
	public GameObject[] die3_images;
	public GameObject[] die4_images;
	public GameObject[] die5_images;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		foreach (GameObject die_image in die1_images) 
		{
			if (System.Array.IndexOf (die1_images, die_image) + 1 == GameState.currentDiceHand [10]) {
				die_image.SetActive (true);
			} else {
				die_image.SetActive (false);
			}
		}

		foreach (GameObject die_image in die2_images) 
		{
			if (System.Array.IndexOf (die2_images, die_image) + 1 == GameState.currentDiceHand [11]) {
				die_image.SetActive (true);
			} else {
				die_image.SetActive (false);
			}
		}

		foreach (GameObject die_image in die3_images) 
		{
			if (System.Array.IndexOf (die3_images, die_image) + 1 == GameState.currentDiceHand [12]) {
				die_image.SetActive (true);
			} else {
				die_image.SetActive (false);
			}
		}

		foreach (GameObject die_image in die4_images) 
		{
			if (System.Array.IndexOf (die4_images, die_image) + 1 == GameState.currentDiceHand [13]) {
				die_image.SetActive (true);
			} else {
				die_image.SetActive (false);
			}
		}

		foreach (GameObject die_image in die5_images) 
		{
			if (System.Array.IndexOf (die5_images, die_image) + 1 == GameState.currentDiceHand [14]) {
				die_image.SetActive (true);
			} else {
				die_image.SetActive (false);
			}
		}
	}
}
