using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {


	public GameObject enemy;
	Vector3 offset;

	void Start () {
		InvokeRepeating ("Spawn", Random.Range (0, 2),Random.Range (0, 2));
	}
	

	void Spawn () {
		offset = new Vector3 (Random.Range (10, 50), Random.Range (10, 50), 0f);
		Instantiate (enemy, transform.position+offset, transform.rotation);
	}
}
