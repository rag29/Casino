using UnityEngine;
using System.Collections;

public class GetRidOfCols : MonoBehaviour {

	public static bool disableCols;

	public GameObject uno, dos, tres, quatro, cinco, seis;

	// Use this for initialization
	void Start () {
	
		disableCols = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (disableCols) 
		{
			uno.SetActive (false);
			dos.SetActive (false);
			tres.SetActive (false);
			quatro.SetActive (false);
			cinco.SetActive (false);
			seis.SetActive (false);
		} 

		else 
		{
			uno.SetActive (true);
			dos.SetActive (true);
			tres.SetActive (true);
			quatro.SetActive (true);
			cinco.SetActive (true);
			seis.SetActive (true);
		}
	}
}
