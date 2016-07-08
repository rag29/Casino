using UnityEngine;
using System.Collections;

public class SelectDiceToKeepScript : MonoBehaviour {

	public static bool keep1;
	public static bool keep2;
	public static bool keep3;
	public static bool keep4;
	public static bool keep5;

	public GameObject die1;
	public GameObject die2;
	public GameObject die3;
	public GameObject die4;
	public GameObject die5;

	// Use this for initialization
	void Start () {
	
		keep1 = false;
		keep2 = false;
		keep3 = false;
		keep4 = false;
		keep5 = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
