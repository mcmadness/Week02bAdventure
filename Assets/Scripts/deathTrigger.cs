using UnityEngine;
using System.Collections;

public class deathTrigger : MonoBehaviour {
	public int damage = 1 ;
	// a function that is automatically called when something with a rigidbody2d enters this trigger
	public bool triggerEnabled = false;

	void OnTriggerEnter2D (Collider2D activator) {
		//does the activating thing have a killable script on it?
		if ((activator.GetComponent<killable>() != null) && (triggerEnabled == true)) {
			//TODO subtract health
			activator.GetComponent<killable>().Hurt(damage);
			//destroy this object
			//	Destroy(activator.gameObject ) ;

		}

	}
	void OnTriggerStay2D (Collider2D activator) {
		//does the activating thing have a killable script on it?
		if ((activator.GetComponent<killable>() != null)&& (triggerEnabled == true) ) {
			//TODO subtract health
			activator.GetComponent<killable>().Hurt(damage);
			//destroy this object
			//	Destroy(activator.gameObject ) ;

		}

	}

}
