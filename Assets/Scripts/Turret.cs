using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

	private GameObject player;
	private float speed = 1f;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		transform.LookAt(player.transform);
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(Vector3.Scale(player.transform.position, new Vector3(1, 0, 1)));
	}
}
