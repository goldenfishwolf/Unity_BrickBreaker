using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead_wall_Controller : MonoBehaviour {

	public Transform ball;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		print("dead");
		ball.position = Game_Controller.gc.not_use_pos;
		ball.GetComponent<Ball_Controller> ().is_run = false;
		ball.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
	}
}
