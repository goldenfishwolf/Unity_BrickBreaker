using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Controller : MonoBehaviour {

	public int block_hp = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name.Substring (0, 4) == "ball") {
			block_hp -= col.gameObject.GetComponent<Ball_Controller> ().ball_atk;
			if (block_hp <= 0) {
				print("destoy " + gameObject.name);
				Destroy (gameObject);
			}
		}

	}
}
