using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    GameObject player;
    public float speed = 0.5f;
    bool shouldMoveTowardPlayer = true;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (player)
        {
            if (shouldMoveTowardPlayer)
            {
                var playerPos = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
                transform.position = Vector3.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
                transform.LookAt(Vector3.Scale(player.transform.position, new Vector3(1, 0, 1)));
            }
        }
        Debug.Log(player);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            shouldMoveTowardPlayer = false;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player" )
        {
            shouldMoveTowardPlayer = true;
        }
    }
}
