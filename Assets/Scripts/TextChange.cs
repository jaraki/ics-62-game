using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextChange : MonoBehaviour {

	Text instruction;
	int insWin;
	// Use this for initialization
	void Start () {
		insWin = 0;
		instruction = GetComponent<Text> ();
	}	
	
	// Update is called once per frame
	void Update () {
		if (insWin == 0) {
			instruction.text = "Oh no! Viruses are invading the body of your host human!\nAs a Helper T-Cell, you are the forefront of the body’s defense system.\nIt’s up to you to produce the Killer T-Cells needed to destroy the viral pathogens, and save the body!\nBut be careful not to shoot your own healthy Red Blood Cells on the way!\n\nThe Immune System has deployed you into the bloodstream where the viral pathogens have been detected.\n\nIt is your job to find and destroy all viral pathogens in the bloodstream.";

		}
		if (insWin == 1) {
			instruction.text = "Use the ARROW KEYS to rotate the bloodstream as you flow through it. The MOUSE, when moved around, will control the camera.\n\nViruses have Antigens on them, which is the only way to determine what kind of a cell it is. Only by using Killer-T Cells of a matching Antigen can you destroy the viral pathogen.\n\nThe Q button can be pressed to shoot a Killer T-Cell with a particular antigen on it. The Killer T-Cell, if shot to a matching virus, will deactivate and destroy the pathogen. Pressing E will switch between the available Antigens.";
		}

		if (insWin == 2) {
			instruction.text = "TIPS:\n\nMake sure to shoot bullets that match color antigens with the enemy, or they will have no effect!\n\n";
		}
	}

	void TextChanger(){
		insWin = insWin + 1;
		if (insWin == 3) {
			insWin = 0;
		}

	}
	void TextChangerMinus(){
		insWin = insWin - 1;
		if (insWin == -1){
			insWin = 2;
		}
	}
}
