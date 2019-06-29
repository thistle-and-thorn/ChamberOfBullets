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
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Cursor.lockState = Cursor.lockState == CursorLockMode.None ? CursorLockMode.Locked : CursorLockMode.None;
            Cursor.visible = Cursor.lockState == CursorLockMode.None;
        }
	}
}
