using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {
    public float numAllowed;
    public Text gameOverText;
    public Text antigenText;
    public static int numViruses;
    // Use this for initialization
    void Start() {
        gameOverText.text = "";
        antigenText.text = "";
    }

    // Update is called once per frame
    void LateUpdate() {
        switch (Shooter.antigen) {
            case Antigen.ZERO:
                antigenText.text = "ZERO";
                break;
            case Antigen.ONE:
                antigenText.text = "ONE";
                break;
            case Antigen.TWO:
                antigenText.text = "TWO";
                break;
        }
        if (gameIsOver()) {
            gameOverText.text = "Game\nOver!";
            Time.timeScale = 0;
        }
    }
    public bool gameIsOver() {
        return (numViruses == 0 && Time.timeSinceLevelLoad > 0f)|| numViruses >= numAllowed;
    }
}
