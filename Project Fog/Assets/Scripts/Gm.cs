using UnityEngine;
using System.Collections;

public class Gm : MonoBehaviour {
	public int playerHealth;
	public int powerUp;
	public bool permaUp1;
	public bool permaUp2;
	public bool permaUp3;
	public bool permaUp4;
	public bool permaUp5;

	void Start () {
	
	}

	void Update () {
	
		if (Input.GetKeyDown("r")) {
			print ("Reloaded");
			Application.LoadLevel(Application.loadedLevel);
		
		}
	}
}
