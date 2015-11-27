using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public Rigidbody2D rb;
	public float speed;
	public float velocity;
	Camera viewCamera;
	// Use this for initialization
	void Start () 
	{
		//Cursor.visible = false;
		rb = GetComponent<Rigidbody2D> ();
		viewCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () 
	{
		float moveVertical = Input.GetAxisRaw ("Vertical");
		float moveHorizontal = Input.GetAxisRaw ("Horizontal");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb.velocity = (movement * speed);

		/*if (Input.mousePosition) 
		{

		}

		if (rigidbody2D.velocity.x >= 0)
		{
			Debug.Log("Moving right " + rigidbody2D.velocity.x);
			transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y);
		}
		else
		{
			Debug.Log("Moving left " + rigidbody2D.velocity.x);
			transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
		}
	}
*/}
}
