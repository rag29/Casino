using UnityEngine;
using System.Collections;

public class ClickToKeep : MonoBehaviour {

	bool clicked;

	public Material white_mat;
	public Material one_mat;
	public Material two_mat;
	public Material three_mat;
	public Material four_mat;
	public Material five_mat;
	public Material six_mat;

	// Use this for initialization
	void Start () {
	
		clicked = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{

		if (GameState.selectDiceToKeep) {

			GameObject die = this.gameObject.transform.parent.gameObject;

			if (!clicked) {

				die.GetComponent<MeshRenderer> ().materials [0].color = Color.cyan;
				die.GetComponent<MeshRenderer> ().materials [1].color = Color.cyan;
				die.GetComponent<MeshRenderer> ().materials [2].color = Color.cyan;
				die.GetComponent<MeshRenderer> ().materials [3].color = Color.cyan;
				die.GetComponent<MeshRenderer> ().materials [4].color = Color.cyan;
				die.GetComponent<MeshRenderer> ().materials [5].color = Color.cyan;
				die.GetComponent<MeshRenderer> ().materials [6].color = Color.cyan;

				switch (this.gameObject.transform.parent.gameObject.tag) {
				case "d1":
					SelectDiceToKeepScript.keep1 = true;
					print (SelectDiceToKeepScript.keep1 + "1");
					break;
				case "d2":
					SelectDiceToKeepScript.keep2 = true;
					print (SelectDiceToKeepScript.keep2 + "2");
					break;
				case "d3":
					SelectDiceToKeepScript.keep3 = true;
					print (SelectDiceToKeepScript.keep3 + "3");
					break;
				case "d4":
					SelectDiceToKeepScript.keep4 = true;
					print (SelectDiceToKeepScript.keep4 + "4");
					break;
				case "d5":
					SelectDiceToKeepScript.keep5 = true;
					print (SelectDiceToKeepScript.keep5 + "5");
					break;
				}

				clicked = true;

			} else {

				Material[] mats = die.GetComponent<MeshRenderer> ().materials;
				mats[0] = white_mat;
				mats[1] = one_mat;
				mats[2] = two_mat;
				mats[3] = three_mat;
				mats[4] = four_mat;
				mats[5] = five_mat;
				mats[6] = six_mat;
				die.GetComponent<MeshRenderer> ().materials = mats;

				switch (this.gameObject.transform.parent.gameObject.tag) {
				case "d1":
					SelectDiceToKeepScript.keep1 = false;
					print (SelectDiceToKeepScript.keep1 + "1");
					break;
				case "d2":
					SelectDiceToKeepScript.keep2 = false;
					print (SelectDiceToKeepScript.keep2 + "2");
					break;
				case "d3":
					SelectDiceToKeepScript.keep3 = false;
					print (SelectDiceToKeepScript.keep3 + "3");
					break;
				case "d4":
					SelectDiceToKeepScript.keep4 = false;
					print (SelectDiceToKeepScript.keep4 + "4");
					break;
				case "d5":
					SelectDiceToKeepScript.keep5 = false;
					print (SelectDiceToKeepScript.keep5 + "5");
					break;
				}

				clicked = false;

			}
		}
	}
}
