using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Controller : MonoBehaviour {


	public static Game_Controller gc;
	public Vector3 not_use_pos = new Vector3(10000,0,0);
	public Vector3 standard_pos;
	public Image transport;

	void Awake()
	{
		if (gc == null) {
			gc = this;
			DontDestroyOnLoad (gameObject);
			standard_pos = transport.transform.position;
		} else {
			Destroy(gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	public IEnumerator change_scene(int id, Color c,float per_fade_out, float per_fade_in)
	{
		for (float i = 0f; i < 1f; i += 0.05f) {
			transport.color = new Color(c.r,c.g,c.b,i);
			yield return new WaitForSeconds (per_fade_out);
		}

		if (id > -1) {
			SceneManager.LoadScene(id);
		}


		for (float i = 1f; i > 0f; i -= 0.05f) {
			transport.color = new Color(c.r,c.g,c.b,i);
			yield return new WaitForSeconds (per_fade_in);
		}
	}

	public IEnumerator twinkle_and_tremble(bool has_tremble,Vector3 direction,float wideth, Color c,float per_fade_out, float per_fade_in)
	{
		for (float i = 0f; i < 0.25f; i += 0.05f) {
			transport.color = new Color(c.r,c.g,c.b,i);
			yield return new WaitForSeconds (per_fade_out);
		};
		for (float i = 0.25f; i < 0.5f; i += 0.05f) {
			transport.color = new Color(c.r,c.g,c.b,i);
			yield return new WaitForSeconds (per_fade_out);
		};
		for (float i = 0.5f; i < 0.75f; i += 0.05f) {
			transport.color = new Color(c.r,c.g,c.b,i);
			yield return new WaitForSeconds (per_fade_out);
		};
		for (float i = 0.75f; i < 1f; i += 0.05f) {
			transport.color = new Color(c.r,c.g,c.b,i);
			yield return new WaitForSeconds (per_fade_out);
		};


		for (float i = 1f; i > 0.75f; i -= 0.05f) {
			transport.color = new Color(c.r,c.g,c.b,i);
			yield return new WaitForSeconds (per_fade_in);
		}
		for (float i = 0.75f; i > 0.5f; i -= 0.05f) {
			transport.color = new Color(c.r,c.g,c.b,i);
			yield return new WaitForSeconds (per_fade_in);
		}
		for (float i = 0.5f; i > 0.25f; i -= 0.05f) {
			transport.color = new Color(c.r,c.g,c.b,i);
			yield return new WaitForSeconds (per_fade_in);
		}
		for (float i = 0.25f; i > 0f; i -= 0.05f) {
			transport.color = new Color(c.r,c.g,c.b,i);
			yield return new WaitForSeconds (per_fade_in);
		}
	}
}
