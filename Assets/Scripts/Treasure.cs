using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement ;

public class Treasure : MonoBehaviour {

	public bool didPlayerWin = false;
	public Text OnScreenText;             // assign in inspector, Text UI
	public Transform PlayerCharacter;         // assign in inspector, player
	public Transform Goal;
	public Transform Hint1;
	public Transform Hint2;
	public Transform Hint3;
	public Transform Hint4;
	public Transform Hint5;
	public GameObject enemy1 ;
	public GameObject enemy2 ;
	public GameObject enemy3 ;
	public GameObject enemy4 ;	





	void start () {

	

	}
	void Update () {
		

		if ((PlayerCharacter.position - Hint1.position).magnitude < 1.1f) {
			OnScreenText.text = "Hello young traveler. I am the Grey Sage, Merek. You're here to find the treasure I presume? I'm afraid I cannot go with you, but I can help you leave this place once you find what you are seeking. As for where to begin your journey I can only offer what my old mentor once told me: \nTo those lost, all you must do is gaze upon the room of light and remind yourself, thrice left yields the right.";


		} else if ((PlayerCharacter.position - Hint2.position).magnitude < 1f) {
			OnScreenText.text = "Helloooooo!!! Hoooooold up both hands, then extend your index finger and thumb. " +
				"Whichever hand makes an L is left! I'd dooooooo it, but I have wings... Hoo-hoot!!";

		} else if ((PlayerCharacter.position - Hint3.position).magnitude < 1f) {
			OnScreenText.text = "Howdy! You lookin' for that treasure too? I'd have it already but somethin's off with my directions. If we was supposed to start off headin' west, then turn left, then turn left again we'd be.... uh.... south? My head's a-hurtin' I think I need ta set down for a spell.";

		} else if ((PlayerCharacter.position - Hint4.position).magnitude < 1f) {
			OnScreenText.text = "YOU dare interrupt ME?! Do you KNOW who I AM?! Do YOU even KNOW who YOU are?! Do I even KNOW who I am?!? WHO AM I?! WHERE AM I?! BAH! SCIENCE shall give me the answers I seek--if ONLY I had some GOLD to transmute! I feel like there's none around here though... hmmm... perhaps I should get some directions... YET being HERE feels so RIGHT.... perhaps I SHOULD'VE LEFT myself a note...";

		} else if ((PlayerCharacter.position - Hint5.position).magnitude < 1f) {
			OnScreenText.text = "Yarr!! Who be ye? HA! Ye be thinkin' ye'll get the treasure! I'd walk the plank before I'd let ye steal it from me grasp! If only I could find it... Ayyy, I feel it be so close I can smell it!";

		} else{
			OnScreenText.text = " ";
		}


		if ( (PlayerCharacter.position - Goal.position).magnitude < .5f) {

			OnScreenText.text = "Aha! The Treasure! \n(Press [SPACE] to take the treasure)";

			if ( Input.GetKey (KeyCode.Space) ) {
				didPlayerWin = true;
			}

		}
		if ( didPlayerWin ) {
			OnScreenText.text = "Oh no! The other travelers are trying to steal the treasure from you! You've got to escape! \nCurrent Health: " + killable.currentHealth;
			enemy1.GetComponent<EnemyFollow> ().enabled = true;
			enemy2.GetComponent<EnemyFollow> ().enabled = true;
			enemy3.GetComponent<EnemyFollow> ().enabled = true;
			enemy4.GetComponent<EnemyFollow> ().enabled = true;
			GetComponent<SpriteRenderer> ().enabled = false;
			GetComponent<BoxCollider2D> ().enabled = false;
		}


		if (((PlayerCharacter.position - Hint1.position).magnitude < 1.1f) && (didPlayerWin == true)) {
			OnScreenText.text = "Quickly now! Take the portal to get out of here! (Press [SPACE] to take the portal)";
			if (Input.GetKeyDown (KeyCode.Space)) {
				SceneManager.LoadScene (3); 

			}

		}

	}
}

