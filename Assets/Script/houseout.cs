using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class houseout : MonoBehaviour {

	GameObject Player = GameObject.Find ("Player");

	void OnTriggerEnter( Collider other )
	{
		// Player태그를 타깃으로 한다.
		if( other.tag == "Player" )
			other.gameObject.transform.position = new Vector3 (54.67f, 2.0f, 95.0f);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
