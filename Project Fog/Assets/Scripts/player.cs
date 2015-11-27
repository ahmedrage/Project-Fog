using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public Rigidbody2D rb;
	public float speed;
	public Transform cursor;
	public int direction;
	// Use this for initialization
	void Start () 
	{
		direction = 1;
		Cursor.visible = false;
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		cursor.position = new Vector2 (Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
		float moveVertical = Input.GetAxisRaw ("Vertical");
		float moveHorizontal = Input.GetAxisRaw ("Horizontal");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb.velocity = (movement * speed);



		if(cursor.position.x < transform.position.x && direction != 2)
		{
			direction = 2;
			horizontalFlip();
		}

		if (cursor.position.x > transform.position.x && direction != 1) 
		{
			direction = 1;
			horizontalFlip();
		}


		if (Input.GetKeyDown (KeyCode.R)) 
		{
			Application.LoadLevel (Application.loadedLevel);
		}
	}

	void horizontalFlip() {

		transform.localScale = new Vector2(transform.localScale.x* -1, transform.localScale.y*1);
	}
}


