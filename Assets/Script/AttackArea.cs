﻿using UnityEngine;
using System.Collections;

public class AttackArea : MonoBehaviour {

	CharacterStatus status;
	// Use this for initialization
	void Start () {
	
		status = transform.root.GetComponent<CharacterStatus> ();
	}
	
	// Update is called once per frame
	public class AttackInfo{
		
		public int attackPower;

		public Transform attacker;
	}

	AttackInfo GetAttackInfo(){
		AttackInfo attackInfo = new AttackInfo();

		attackInfo.attackPower = status.Power;
		attackInfo.attacker = transform.root;

		return attackInfo;
	}

	void OnTriggerEnter(Collider other){
	
		other.SendMessage ("Damage", GetAttackInfo ());

		status.lastAttackTarget = other.transform.root.gameObject;
	}

	void OnAttack(){
	
	//collider.enabled = true;
	
	}

	void OnAttackTermination(){
	//collider.enabled = false;
	}
	void Update () {
	
	}
}