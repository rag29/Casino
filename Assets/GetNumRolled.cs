using UnityEngine;
using System.Collections;

public class GetNumRolled : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		switch (other.gameObject.tag)
		{
		case "1":
			GameState.currentDiceHand.Add (1);
			print ("1");
			break;
		case "2":
			GameState.currentDiceHand.Add (2);
			print ("2");
			break;
		case "3":
			GameState.currentDiceHand.Add (3);
			print ("3");
			break;
		case "4":
			GameState.currentDiceHand.Add (4);
			print ("4");
			break;
		case "5":
			GameState.currentDiceHand.Add (5);
			print ("5");
			break;
		case "6":
			GameState.currentDiceHand.Add (6);
			print ("6");
			break;
		}

	}
}
