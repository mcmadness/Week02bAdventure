using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement ; 

public class Restart : MonoBehaviour {


	void Update () {
		if (Input.GetKeyDown(KeyCode.R)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex); //restart it on current scene

		}
	}
}
