﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

	private Vector2 mouseLook;
	private Vector2 smoothV;
    public float mouseClampDegree = 75f;
	public float sensitivity = 5.0f;
	public float smoothing = 2.0f;

	GameObject character;

	// Use this for initialization
	void Start () {
		character = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        // only activate camera movement if locked on window
        if (Cursor.lockState == CursorLockMode.Locked)
        {
		    var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
		    md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
		    smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
		    smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
		    mouseLook += smoothV;

            if (Mathf.Abs(mouseLook.y) >= mouseClampDegree)
            {
                mouseLook.y = mouseClampDegree * Mathf.Sign(mouseLook.y);
            }

		    transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
		    character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
        }
	}
}
