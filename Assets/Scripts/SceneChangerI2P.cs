using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement ; //need to load scenes


public class SceneChangerI2P : MonoBehaviour {

	void Update () {

		//if player pressed space load scene number 2 (Main Game)
		if (Input.GetKeyDown (KeyCode.Space)) {
			SceneManager.LoadScene (2); 

		}
			
	}
}

