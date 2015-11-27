using UnityEngine;
using System.Collections;

public class treeFade : MonoBehaviour {

	public Color fade;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.Space)) 
		{
			GetComponent<Renderer> ().material.color = fade;

		}
	
	}
}

