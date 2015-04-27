using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

    public void LoadLevel(string action) {
        if (action == "Main") {
            Application.LoadLevel("Main");
        } else if (action == "Instructions") {
            Application.LoadLevel("Instructions");
        } else if (action == "Menu"){
            Application.LoadLevel("Menu");   
        }else if (action == "Exit") {
            Application.Quit();
        }
        //Debug.Log("press");

    }

}
