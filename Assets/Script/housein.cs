using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class housein : MonoBehaviour {



	void OnTriggerEnter( Collider other )
	{
		// Player태그를 타깃으로 한다.
		if (other.tag == "Player") {
			other.gameObject.GetComponent<CharacterMove> ().arrived = true;
			other.gameObject.transform.position = new Vector3 (-642.5f,2.0f,73.98f);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
