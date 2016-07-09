using UnityEngine;
using System.Collections;

public class RollDice_Animations3 : MonoBehaviour {


	Animator anim;

	public bool playIt;

	int rand_int;

	bool keep_this;

	// Use this for initialization
	void Start () 
	{

		anim = GetComponent<Animator> ();

		playIt = true;

		rand_int = Mathf.CeilToInt(Random.Range(1,6));

	}

	// Update is called once per frame
	void Update () {

		switch (this.gameObject.tag) 
		{

		case "d1":
			keep_this = SelectDiceToKeepScript.keep1;
			break;
		case "d2":
			keep_this = SelectDiceToKeepScript.keep2;
			break;
		case "d3":
			keep_this = SelectDiceToKeepScript.keep3;
			break;
		case "d4":
			keep_this = SelectDiceToKeepScript.keep4;
			break;
		case "d5":
			keep_this = SelectDiceToKeepScript.keep5;
			break;

		}

		if (playIt  && !keep_this) 
		{
			rand_int = Mathf.CeilToInt(Random.Range(1,6));
			anim.SetInteger ("PlayNum", rand_int);
			playIt  = false;
		}

		else if (GameState.switch_cam && !keep_this) 
		{
			if (GameState.t1 > 1.5f) {
				rand_int = Mathf.CeilToInt (Random.Range (1, 6));
				anim.SetInteger ("PlayNum", rand_int);

			} else {
				anim.SetInteger ("PlayNum", 0);
			}

		}
	}

	//	void OnRoll()
	//	{
	//		
	//	}
}