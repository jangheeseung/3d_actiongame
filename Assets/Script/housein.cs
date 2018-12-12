using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class housein : MonoBehaviour {

	GameObject Player = GameObject.Find ("Player");

	void OnTriggerStay( Collider other )
	{
		// Player태그를 타깃으로 한다.
		if( other.tag == "Player" )
			SceneManager.LoadScene ("Housein");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
