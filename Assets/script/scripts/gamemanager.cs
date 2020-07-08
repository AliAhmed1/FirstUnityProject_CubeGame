using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour {

    public bool gamehasended=false;
    public float restartdelay = 1;

    public GameObject completelevelUI;
    public void completelevel()
    {
        Debug.Log("level complete");
        completelevelUI.SetActive(true);
    }
    public void Endgame()
    {
        if (gamehasended == false)
        {
            gamehasended =true;
            Debug.Log("game over");
            Invoke("restart", restartdelay);
        }
       
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
