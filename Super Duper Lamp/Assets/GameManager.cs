using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    // A publicly accessible variable that contains the one instance of GameManager (the script)
    // This can be accessed anywhere by doing GameManager.instance
    public static GameManager instance;

	// Use this for initialization
	void Start () {
        // Set instance to be this newly created object when it starts
        if (instance == null)
        {
            instance = this;
        }


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
