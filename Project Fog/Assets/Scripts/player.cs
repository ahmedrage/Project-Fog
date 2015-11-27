using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public Rigidbody2D rb;
	public float speed;
	public float velocity;
	public float rotate;
	// Use this for initialization
	void Start () 
	{
		//Cursor.visible = false;
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float moveVertical = Input.GetAxisRaw ("Vertical");
		float moveHorizontal = Input.GetAxisRaw ("Horizontal");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb.velocity = (movement * speed);

		if(Input.mousePosition.x < transform.localScale.x)
		{
			transform.localScale = new Vector2(transform.localScale.x* -1, transform.localScale.y*1);
		}

		if (Input.GetKeyDown (KeyCode.R)) 
		{
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}


