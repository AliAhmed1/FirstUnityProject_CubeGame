using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endtrigger : MonoBehaviour {

    public gamemanager Gamemanager;
    public void OnTriggerEnter()
    {
        Gamemanager.completelevel();
    }
}
