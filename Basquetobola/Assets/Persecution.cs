using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Persecution : MonoBehaviour {

	GameObject player;

	void Start(){
		player = GameObject.FindGameObjectWithTag("Player");
		if(!player){
			Debug.Log("Make sure your player is tagged!!");
		}
	}
	void Update()
	{
		GetComponent<NavMeshAgent>().destination = player.transform.position;
	}
}
