using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Treasure : MonoBehaviour {

	bool didPlayerWin = false;
	public Text OnScreenText;             // assign in inspector, Text UI
	public Transform PlayerCharacter;         // assign in inspector, player

	void Update () {

		if ( (PlayerCharacter.position - transform.position).magnitude < 5f) {

			OnScreenText.text = "Find the Treasure then press [SPACE] to win!";
			if ( Input.GetKey (KeyCode.Space) ) {
				didPlayerWin = true;
			}
			if ( didPlayerWin ) {
				OnScreenText.text = "YOU GOT THE TREASURE AND YOU WIN!!";
			}
		} 
	}
}