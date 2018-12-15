using UnityEngine;
using System.Collections;

public class DateContoller : MonoBehaviour {

	// Use this for initialization
	private int hpgagenum=0;

	void Awake(){
	
		hpgagenum = PlayerPrefs.GetInt ("Forward");


	}

	public void Sethpgahe(int gethpgage){
	
		hpgagenum = gethpgage;
		PlayerPrefs.SetInt ("Forward", hpgagenum);
	}
}
