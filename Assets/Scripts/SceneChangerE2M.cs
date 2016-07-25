using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement ; //need to load scenes


public class SceneChangerE2M : MonoBehaviour {

	void Update () {

		//if player pressed space load scene number 0 (Menu)
		if (Input.GetKeyDown (KeyCode.Space)) {
			SceneManager.LoadScene (0); 

		}




	}
}

