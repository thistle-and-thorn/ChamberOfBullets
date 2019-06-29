using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	float speed = 10f;

	private Vector3 GetTranslationVector() {
        Vector3 moveDirectionForward = transform.forward * Input.GetAxis("Vertical");
        Vector3 moveDirectionRight = transform.right * Input.GetAxis("Horizontal");
		return (moveDirectionForward + moveDirectionRight).normalized * speed * Time.deltaTime;
	}

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
        var cc = GetComponent<CharacterController>();
        cc.Move(GetTranslationVector());
    }
}
