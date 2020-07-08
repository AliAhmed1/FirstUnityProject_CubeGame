using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour {

    public playermovement movement;
    public gamemanager Gamemanager;
    // Use this for initialization

    private void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<gamemanager>().Endgame();

        }
    }
}
