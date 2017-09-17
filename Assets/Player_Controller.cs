using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {

	public Transform ball;
	public Vector3 player_standard_pos;
	// Use this for initialization
	void Start () {
		player_standard_pos = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			Vector3 tem = gameObject.transform.position;
			gameObject.transform.position += new Vector3 (10, 0, 0);
			if (gameObject.transform.position.x > player_standard_pos.x + 268) {
				gameObject.transform.position = new Vector3 (player_standard_pos.x + 268, gameObject.transform.position.y, gameObject.transform.position.z);
			}

			if (ball.GetComponent<Ball_Controller> ().is_run) {
				ball.position -= gameObject.transform.position - tem;
			}


		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			Vector3 tem = gameObject.transform.position;
			gameObject.transform.position -= new Vector3 (10, 0, 0);
			if (gameObject.transform.position.x < player_standard_pos.x - 268) {
				gameObject.transform.position = new Vector3(player_standard_pos.x - 268,gameObject.transform.position.y,gameObject.transform.position.z);
			}
			if (ball.GetComponent<Ball_Controller> ().is_run) {
				ball.position -= gameObject.transform.position - tem;
			}

		}
	}
}
