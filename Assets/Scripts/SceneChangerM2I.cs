using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement ; 

public class SceneChangerM2I : MonoBehaviour {

	void Update () {

		//if player pressed space load scene number 1 (Instructions)
		if (Input.GetKeyDown (KeyCode.Space)) {
			SceneManager.LoadScene (1); 

		}



	}

}
