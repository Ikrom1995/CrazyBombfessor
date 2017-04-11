using UnityEngine;
using System.Collections;

public class LoadingScreenScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        //after 3 seconds pass from the loading of the scene main menu scene will be opened
        if (Mathf.Round(Time.timeSinceLevelLoad) == 3)
            Application.LoadLevel("MainMenu");
	}
}
