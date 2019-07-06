using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

	private LineRenderer lineR;
	private GameObject player;
	private float speed = 1f;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		transform.LookAt(player.transform);
		lineR = GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		var playerPosition = Vector3.Scale(player.transform.position, new Vector3(1, 0, 1));
		transform.LookAt(playerPosition);
		lineR.SetPosition(0, transform.position + new Vector3(0, 0.6f,0));
		lineR.SetPosition(1, player.transform.position - new Vector3(0, 0.6f, 0));
	}
}
