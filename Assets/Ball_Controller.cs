using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ball_Controller : MonoBehaviour,IPointerClickHandler {

	public int ball_atk;
	public bool is_run = false;

	public Vector3 ball_standard_pos;
	// Use this for initialization
	void Start () {
		
		ball_atk = 1;
		ball_standard_pos = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerClick(PointerEventData e)
	{
		is_run = true;
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(200,200);
	}
}
