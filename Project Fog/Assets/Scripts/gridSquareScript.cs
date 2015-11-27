using UnityEngine;
using System.Collections;

public class gridSquareScript : MonoBehaviour {

	private int randomEvent;
	public Sprite event1;
	public Sprite event2;
	public Sprite event3;
	public SpriteRenderer mySpriteRenderer;

	void Start () {
		mySpriteRenderer = gameObject.GetComponent<SpriteRenderer> ();;
		randomEvent = Random.Range (1, 3);

		switch (randomEvent) {
		case 1:
			mySpriteRenderer.sprite = event1;
			break;
		case 2:
			mySpriteRenderer.sprite = event2;
			break;
		case 3:
			mySpriteRenderer.sprite = event3;
			break;
		
		default:
			break;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
