using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	[SerializeField] private float speed = 10f;

	private Vector3 GetTranslationVector() {
		float zDelta = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		float xDelta = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		return new Vector3(xDelta, 0, zDelta);
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
		transform.Translate(GetTranslationVector());
	}
}
