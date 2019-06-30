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
		// float step = speed * Time.deltaTime;

		// Vector3 newDir = Vector3.RotateTowards(transform.forward, player.transform.position, step, 0.0f);
		// newDir.Scale(new Vector3(1, 0, 1));
		// Debug.DrawRay(transform.position, newDir, Color.red);

        // // Move our position a step closer to the target.
        // transform.rotation = Quaternion.LookRotation(newDir);
	}
}
