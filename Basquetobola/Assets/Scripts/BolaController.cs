using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour {

	public int speed, jump;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce (new Vector3(Input.GetAxis ("Vertical")*speed,0,Input.GetAxis ("Horizontal")*-speed) );

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			rb.AddForce (Vector3.up*jump,ForceMode.Impulse);
		}
	}
}
