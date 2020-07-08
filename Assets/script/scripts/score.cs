
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {

    public Transform player;
    public Text textscore;
	
	// Update is called once per frame
	void Update () {
        textscore.text = player.position.z.ToString("0");
	}
}
