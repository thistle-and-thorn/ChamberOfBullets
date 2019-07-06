using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baddy : MonoBehaviour
{
    static readonly string ANIM_IS_WALKING = "IsWalking";
    GameObject player;
    public float speed = 5f;
    bool shouldMoveTowardPlayer = true;
    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

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
                anim.SetBool(ANIM_IS_WALKING, true);
            } else
            {
                anim.SetBool(ANIM_IS_WALKING, false);
            }
        }
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
