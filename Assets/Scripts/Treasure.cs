using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Treasure : MonoBehaviour {

	bool didPlayerWin = false;
	public Text OnScreenText;             // assign in inspector, Text UI
	public Transform PlayerCharacter;         // assign in inspector, player
	public Transform Goal;
	public Transform Hint1;
	public Transform Hint2;
	public Transform Hint3;
	public Transform Hint4;
	public Transform Hint5;

	void Update () {


		if ((PlayerCharacter.position - Hint1.position).magnitude < 1f) {
			OnScreenText.text = "A wise man once said, ‘Three lefts makes a right’.";

		} else if ((PlayerCharacter.position - Hint2.position).magnitude < 1f) {
			OnScreenText.text = "My mama always said, ‘Hold up both hands, then extend your index finger and thumb." +
				"Whichever hand makes an L is left!’";

		} else if ((PlayerCharacter.position - Hint3.position).magnitude < 1f) {
			OnScreenText.text = "Looks like we’re both bad at sumthin’ pardner... followin’ directions.";

		} else if ((PlayerCharacter.position - Hint4.position).magnitude < 1f) {
			OnScreenText.text = "Just follow the directions once more... WITH FEELING!";

		} else if ((PlayerCharacter.position - Hint5.position).magnitude < 1f) {
			OnScreenText.text = "Yarr!! Almost there laddie. Just think... which way do pirates dig to bury der treasure?";

		} else{
			OnScreenText.text = "Find the Treasure then press [SPACE] to win!\nWalk up to fellow travelers to receive hints!";
		}


		if ( (PlayerCharacter.position - Goal.position).magnitude < 5f) {

			OnScreenText.text = "Find the Treasure then press [SPACE] to win!\nWalk up to fellow travelers to receive hints!";

			if ( Input.GetKey (KeyCode.Space) ) {
				didPlayerWin = true;
			}
			if ( didPlayerWin ) {
				OnScreenText.text = "YOU GOT THE TREASURE AND YOU WIN!!";
			}
		}

	}
}