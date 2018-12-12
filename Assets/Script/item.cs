using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class item : MonoBehaviour {

	GameObject hpGage;
	GameObject Player;
	// Use this for initialization
	void Start () {
		this.hpGage = GameObject.Find ("Forward");
		Player = GameObject.Find ("Player");
	}

	void OnTriggerStay( Collider other )
	{
		// Player태그를 타깃으로 한다.
		if (other.tag == "Player") {
			GetComponent<AudioSource> ().Play ();
			Player.GetComponent<CharacterStatus> ().HP += 20;
			Destroy(gameObject,0.3f);
		}	
	}

	// Update is called once per frame
	void Update () {
	
	}
}
