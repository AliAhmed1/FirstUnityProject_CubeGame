using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardforce = 2000;
    public float sidewayforce = 500;
	// Use this for initialization
	void Start () {
			}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(0,0,forwardforce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayforce * Time.deltaTime,0,0 , ForceMode.VelocityChange);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayforce *Time.deltaTime, 0, 0 , ForceMode.VelocityChange);

        }
        if (rb.position.y < -1)
        {
            FindObjectOfType<gamemanager>().Endgame();
        }
    }
}
