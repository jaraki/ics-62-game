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
            case Antigen.BLUE:
                antigenText.text = "BLUE";
                break;
            case Antigen.GREEN:
                antigenText.text = "GREEN";
                break;
            case Antigen.PURPLE:
                antigenText.text = "PURPLE";
                break;
        }
        if (gameIsOver()) {
            gameOverText.text = "Game\nOver!";
            Time.timeScale = 0;
        }
    }
    public bool gameIsOver() {
        return false;
    }
}
