using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Game : MonoBehaviour {
    public float numAllowed;
    public Text gameOverText;
    public static int numViruses;
    // Use this for initialization
    void Start() {
        gameOverText.text = "";

    }

    // Update is called once per frame
    void Update() {
        if (gameIsOver()) {
            gameOverText.text = "Game\nOver!";
            Time.timeScale = 0;
        }
    }
    public bool gameIsOver() {
        return (numViruses == 0 && Time.timeSinceLevelLoad > 0f)|| numViruses >= numAllowed;
    }
}
