using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// KEY INTERACTIONS
	private List<KeyCode> FORWARD = new List<KeyCode>() { 
		KeyCode.W, KeyCode.UpArrow 
	};
	private List<KeyCode> BACK = new List<KeyCode>() { 
		KeyCode.S, KeyCode.DownArrow 
	};
	private List<KeyCode> STRAFE_LEFT = new List<KeyCode>() { 
		KeyCode.A, KeyCode.LeftArrow 
	};
	private List<KeyCode> STRAFE_RIGHT = new List<KeyCode>() { 
		KeyCode.D, KeyCode.RightArrow 
	};

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
