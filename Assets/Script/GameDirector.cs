using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {

	GameObject hpGage;
	GameObject Player;
	// Use this for initialization
	void Start () {
		this.hpGage = GameObject.Find ("Forward");
		Player = GameObject.Find ("Player");
	}

	void Update () {
	
		hpGage.GetComponent<Image> ().fillAmount = Player.GetComponent<CharacterStatus> ().HP/100f;

		if(hpGage.GetComponent<Image>().fillAmount==0)
			SceneManager.LoadScene ("GameOverScene");

	}
} 
