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
	
	// Update is called once per frame
	void Update () {
        var cc = GetComponent<CharacterController>();
        cc.Move(GetTranslationVector());
    }
}
